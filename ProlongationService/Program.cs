using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProlongationService;
using ProlongationService.Code;
using ProlongationService.Services;
using Quartz;
using RegOffice.AstralLogger;
using RegOffice.DataModel;
using RegOffice.DataModel.Model;
using System.Globalization;

namespace ProlongationService
{
    internal partial class Program
    {

        private static IConfigurationRoot _configuration = new ConfigurationBuilder()
#if DEBUG
                                                               .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
#else
                                                               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
#endif
                                                               .Build();

        private static async Task Main(string[] args)
        {
            //глобальный логгер, который реагирует на не запуск приложения
            AppLoggerExtensions.CreateGlobalLogger(_configuration);

            try
            {

                CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

                AppLoggerExtensions.Information("Запуск сервиса ProlongationService");
                IHost host = CreateHostBuilder(args).Build();
                var schedulerFactory = host.Services.GetRequiredService<ISchedulerFactory>();
                var scheduler = await schedulerFactory.GetScheduler();

                var job = JobBuilder.Create<SchedulerService>()
                    .WithIdentity("prolongationServiceJob", "group1")
                    .Build();

                var trigger = TriggerBuilder.Create()
                    .WithIdentity("DailyTrigger", "group1")
                    .WithCronSchedule(_configuration["CronTrigger"])
                    .ForJob("prolongationServiceJob", "group1")
                    .Build();

                await scheduler.ScheduleJob(job, trigger);
                await host.RunAsync();

                AppLoggerExtensions.CloseAndFlush();
            }
            catch (Exception ex)
            {
                AppLoggerExtensions.Fatal(ex, "Критическая ошибка сервиса ProlongationService");
            }
            finally
            {
                AppLoggerExtensions.Information("Остановка сервиса ProlongationService");
                AppLoggerExtensions.CloseAndFlush();
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseAstralLogger(_configuration)
                .ConfigureServices((context, services) =>
                {
                    var postgresConnectionString = _configuration.GetSection("Postgres").GetValue<string>("ConnectionString");

                    services
                        //.AddHandlebarsScaffolding()
                        .AddSingleton<IAppLogger, AppLogger>()
                        .AddDbContextFactory<PostgreeSqlContext>(options =>
                        {
                            options.UseNpgsql(postgresConnectionString, o => o.CommandTimeout(600));
                        })
                        //.AddSingleton(new NpgsqlConnectionFactory(postgresConnectionString))
                        //.AddSingleton<IDataEngine, DataEngine>()
                        .AddSingleton<IRepository, Repository>()
                        .AddSingleton<Manager>()                      
                        .AddSingleton<IDocflowsStatisticsService, DocflowsStatisticsService>()
                        .AddSingleton<IJob, SchedulerService>()
                        .AddQuartz(q =>
                        {
                            q.UseMicrosoftDependencyInjectionJobFactory();
                        })
                        .AddQuartzHostedService(opt =>
                        {
                            opt.WaitForJobsToComplete = true;
                        });


                })
            .UseWindowsService();



    }
}


