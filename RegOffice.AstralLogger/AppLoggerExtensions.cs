using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;


namespace RegOffice.AstralLogger
{
    public static class AppLoggerExtensions
    {
        /// <summary>
        /// Специфический логгер, пишущий в Logstash
        /// здесь статический логгер переписывется этим логгером, т.к. preserveStaticLogger = false
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IHostBuilder UseAstralLogger(this IHostBuilder builder, IConfigurationRoot config)
        {
            builder.UseSerilog((context, services, configuration) => configuration
                .ReadFrom.Configuration(config)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .WriteTo.Http(requestUri: config["LogstashUri"], queueLimitBytes: null)
                );
            return builder;
        }

        /// <summary>
        /// Глобальный логгер - статический, создается и применяется
        /// до создания сервисов, чтобы реагировать на не запуск
        /// </summary>
        /// <param name="configuration"></param>
        public static void CreateGlobalLogger(IConfigurationRoot configuration)
        {
            Serilog.Debugging.SelfLog.Enable(Console.WriteLine);
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Http(requestUri: configuration["LogstashUri"], queueLimitBytes: null)
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public static void Information(string message)
        {
            Log.Information(message);
        }

        public static void CloseAndFlush()
        {
            Log.CloseAndFlush();
        }

        public static void Fatal(Exception ex, string message)
        {
            Log.Fatal(ex, message);
        }

    }
}