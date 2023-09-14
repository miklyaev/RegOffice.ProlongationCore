using HandlebarsDotNet;
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
        private readonly PostgreeSqlContext _context;
        public SchedulerService(Manager manager, IRepository repository, ILogger logger)
        { 
            _logger = logger;
            _manager = manager;
            _context = repository.GetContext(); 
        }

        public void DoWork(bool updateNoDispach)
        {           
            _manager.RemoveOutdatedProlongationData();
            _manager.RemoveUnactiveProductsData();
            _manager.RemoveTransferredProductsData();

            _manager.ProcessProlongationShortData();
            _logger.Information("Обновление партнёров выполнено.");

           if (updateNoDispach)
            {
                _manager.UpdateNoDispatchFlags(DateTime.Now.Day != 1);
            }
        }
        public async Task Execute(IJobExecutionContext context)
        {
            _logger.Information("Start SchedulerService");

            bool updateNoDispach = DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 2;

           
            try
            {
                _context.Database.SetCommandTimeout(600);
                var connectionString = _context.Database.GetConnectionString();
                var partOfConStr = connectionString.Substring(0, connectionString.Length - connectionString.IndexOf("Username") - 1);
                _logger.Information($"Подключение к базе выполнено: {partOfConStr}");
                await Task.Run(() => DoWork(updateNoDispach));
                _context.Database.CloseConnection();
                _logger.Information("Stop SchedulerService");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "{ErrorMessage}", ExceptionFilter.GetMessage(ex));
            }
        }
    }
}
