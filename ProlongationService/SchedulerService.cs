using ProlongationService.Code;
using Quartz;
using ILogger = Serilog.ILogger;

namespace ProlongationService
{
    public class SchedulerService : IJob
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger _logger;
        private readonly Manager _manager;
        public SchedulerService(IConfiguration configuration, Manager manager, IServiceProvider serviceProvider, ILogger logger)
        {
            _configuration = configuration;
            _serviceProvider = serviceProvider;
            _logger = logger;
            _manager = manager;

        }
        public async Task Execute(IJobExecutionContext context)
        {
            _logger.Information("Start SchedulerService");

            await Task.Delay(5000);
        }
    }
}
