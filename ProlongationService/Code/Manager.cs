using Microsoft.EntityFrameworkCore.Storage;
using ProlongationService.Containers;
using ProlongationService.Services;
using RegOffice.AstralLogger;
using RegOffice.DataModel;
using RegOffice.DataModel.Model;
using RegOffice.General.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlongationService.Code
{
    public class Manager
    {
        private readonly IRepository _repository;
        private readonly PostgreeSqlContext _context;
        private readonly IAppLogger _logger;
        private readonly IDocflowsStatisticsService _docflowsStatisticsService;

        public Manager(IRepository repository, IDocflowsStatisticsService docflowsStatisticsService, IAppLogger logger)
        {
            _repository = repository;
            _logger = logger;
            _docflowsStatisticsService = docflowsStatisticsService;
            _context = repository.GetContext();
        }

        private readonly List<int> _protocols = new List<int> { 2, 13 };

        public void ProcessProlongationShortData()
        {
            var products = new[]
            {
                (int) ProductTypeInfo.Mercury,
                (int) ProductTypeInfo.Niobium,
                (int) ProductTypeInfo.Dysprosium,
                (int) ProductTypeInfo.Krypton,
                (int) ProductTypeInfo.Venus,
                (int) ProductTypeInfo.Curium,
                (int) ProductTypeInfo.Sedna
            };

            var agentIds = _repository.GetProductAgents(products).ToList();

            foreach (var agentId in agentIds)
            {
                IDbContextTransaction transaction = null;
                try
                {
                    var prdata = _repository.ProlongationDataLinq(agentId, products);

                    transaction = _context.Database.BeginTransaction();

                    foreach (var psdInfo in prdata)
                    {
                        var psdBase =
                            _repository.GetProlongationShortDatum(psdInfo.ProductId, psdInfo.ContractId);

                        psdBase = psdBase == null
                            ? _repository.AddProlongationShortDatum(psdInfo)
                            : _repository.UpdateProlongationShortDatum(psdBase, psdInfo);

                        _context.SaveChanges();
                    }

                    _repository.UpdateShortDataSummary(agentId);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    _logger.Error(ex, "Ошибка при обновлении партнера: {agentId}, {ErrorMessage}", agentId, ExceptionFilter.GetMessage(ex));
                }
                finally
                {
                    transaction?.Dispose();
                }
            }
        }

        public void RemoveOutdatedProlongationData()
        {
            var outdatedProlongationData = _repository.GetOutdatedProlongationData();

            foreach (var outdatedProlongationDatum in outdatedProlongationData)
            {
                _repository.RemoveProlongationShortDatum(outdatedProlongationDatum);
            }

            _context.SaveChanges();
        }

        public void RemoveUnactiveProductsData()
        {
            var unactiveProlongationData = _repository.GetUnactiveProlongationData();

            foreach (var unactiveProlongationDatum in unactiveProlongationData)
            {
                _repository.RemoveProlongationShortDatum(unactiveProlongationDatum);
            }

            _context.SaveChanges();
        }

        public void RemoveTransferredProductsData()
        {
            var transferredData = _repository.GetTransferredProlongationData();

            foreach (var prolongationShortDatum in transferredData)
            {
                _repository.RemoveProlongationShortDatum(prolongationShortDatum);
            }

            _context.SaveChanges();
        }

        public void UpdateNoDispatchFlags(bool partial)
        {
            var abonentsIds = partial
                ? _repository.GetNoDispatchAbonentsIds()
                : _repository.GetAbonentsIds();

            int counter = 0;
            int _portionSize = 700;
            DateTime begin = DateTime.Now.AddDays(-90);
            DateTime end = DateTime.Now.AddDays(1);

            int attemptCount = 0;

            while (true)
            {
                var ids = abonentsIds.Take(_portionSize).ToList();
                var guids = _repository.GetAbonentsGuids(ids);

                try
                {
                    List<DocflowsStatisticsData> docflowsStatistics = _docflowsStatisticsService.GetDocflowsStatistics(guids, begin, end);
                    UpdateNoDispatchFlags(ids, docflowsStatistics);
                    UpdateOfdNoDispatchFlags(docflowsStatistics);
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "Ошибка при актуализации флага отсутствия отправок.");
                    if (attemptCount < 1)
                    {
                        attemptCount += 1;
                        continue;
                    }
                    _logger.Error("Превышено максимальное число попыток получения данных.");
                }

                if (abonentsIds.Count > _portionSize)
                    abonentsIds.RemoveRange(0, _portionSize);
                else
                    break;

                if (counter % (_portionSize * 5) == 0)
                {
                    //_context.Reopen();
                    //_repository = new Repository(_dataEngine);
                    _logger.Information("Обработка очередной порции данных завершена. Остаток: {abonentsIds.Count}.", abonentsIds.Count);
                }

                counter += _portionSize;
                attemptCount = 0;
            }
            _logger.Information("Сервис обновил все данные об отправках");

        }

        private void UpdateNoDispatchFlags(List<int> abonentsIds, List<DocflowsStatisticsData> docflowsStatistics)
        {
            foreach (var abonentId in abonentsIds)
            {
                var abonentProlongationShortData = _repository.GetAbonentProlongationShortData(abonentId);
                var protocols = abonentProlongationShortData.SelectMany(p => p.Product.MercuryRecipients.Where(m => _protocols.Contains(m.Recipient.ProtocolId)).
                     Select(k => k.Recipient.ProtocolId)).Distinct().ToList();

                var abonentStatistics = docflowsStatistics.Where(p => abonentProlongationShortData.Select(s => s.Product.ProductGuid).Distinct().ToList().Contains(p.Guid)).ToList();
                bool noDispatch = false;

                foreach (var protocol in protocols)
                {
                    if (protocol == 13)
                        if (!abonentStatistics.Any(p => p.Fns != 0))
                        {
                            noDispatch = true;
                            break;
                        }
                    if (protocol == 2)
                        if (!abonentStatistics.Any(p => p.Pfr != 0))
                        {
                            noDispatch = true;
                            break;
                        }
                }

                foreach (var abonentProlongationShortDatum in abonentProlongationShortData)
                    abonentProlongationShortDatum.NoDispatch = noDispatch;

            }
            _context.SaveChanges();
        }

        private void UpdateOfdNoDispatchFlags(List<DocflowsStatisticsData> docflowsStatistics)
        {
            var ofd = docflowsStatistics.Where(x => x.HasOfdCashReport).Select(x => x.Guid).ToList();

            if (!ofd.Any())
                return;

            foreach (var guid in ofd)
            {
                var prolongationShortDatum = _context.ProlongationShortDatas.First(x => x.Product.ProductGuid == guid);
                prolongationShortDatum.NoDispatch = true;
            }

            _context.SaveChanges();
        }

    }
}
