using Microsoft.EntityFrameworkCore;
using ProlongationService.Code;
using Quartz;
using RegOffice.AstralLogger;
using RegOffice.DataModel;
using RegOffice.DataModel.Model;
using ILogger = Serilog.ILogger;

namespace ProlongationService
{
    public class SchedulerService : IJob
    {
        private readonly ILogger _logger;
        private readonly Manager _manager;
        //private readonly IDataEngine _dataEngine;
        //private readonly IRepository _repository;
        private readonly PostgreeSqlContext _context;
        public SchedulerService(Manager manager, IRepository repository, ILogger logger)
        { 
            _logger = logger;
            _manager = manager;
            //_repository = repository;
            _context = repository.GetContext();
            //_dataEngine = dataEngine;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            _logger.Information("Start SchedulerService");

            bool updateNoDispach = DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 2;

            _context.Database.SetCommandTimeout(600);//SetTimeout(600);

            //if (!_context.Open())
            //{
            //    _logger.Error("Ошибка подключения к базе данных RegOffice.");
            //}

            try
            {
                var task1 = Task.Run(_manager.RemoveOutdatedProlongationData);
                var task2 = Task.Run(_manager.RemoveUnactiveProductsData);
                var task3 = Task.Run(_manager.RemoveTransferredProductsData);
                await Task.WhenAll(task1, task2, task3);

                _manager.ProcessProlongationShortData();

                if (updateNoDispach)
                {
                    _manager.UpdateNoDispatchFlags(DateTime.Now.Day != 1);
                }

                _logger.Information("Stop SchedulerService");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "{ErrorMessage}", ExceptionFilter.GetMessage(ex));
            }
        }
    }
}
