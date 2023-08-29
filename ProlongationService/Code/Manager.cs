using ProlongationService.Containers;
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
        private readonly IDataEngine _dataEngine;
        private IRepository _repository;

        public Manager(IRepository repository)
        {
            _repository = repository;
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
                IDbTransaction transaction = null;
                try
                {
                    var prdata = _repository.ProlongationDataLinq(agentId, products);

                    transaction = _dataEngine.BeginTransaction();

                    foreach (var psdInfo in prdata)
                    {
                        var psdBase =
                            _repository.GetProlongationShortDatum(psdInfo.ProductId, psdInfo.ContractId);

                        psdBase = psdBase == null
                            ? _repository.AddProlongationShortDatum(psdInfo)
                            : _repository.UpdateProlongationShortDatum(psdBase, psdInfo);

                        _dataEngine.SaveChanges();
                    }

                    _repository.UpdateShortDataSummary(agentId);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();

                    string message = $"Ошибка при обновлении партнера: {agentId}\n" +
                                     $"{(ex.InnerException == null ? ex.Message : $"Exception Message: {ex.Message}\n InnerException Message:{ex.InnerException.Message} ")}" +
                                     $"{ex.StackTrace}";

                    ServiceLogger.WriteLog(message, LogTypeInfo.Error, ApplicationInfo.ProlongationService, _dataEngine);
                }
                finally
                {
                    transaction?.Dispose();
                }
            }
        }
    }
}
