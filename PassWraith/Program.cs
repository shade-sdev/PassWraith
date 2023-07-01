using Microsoft.Extensions.DependencyInjection;
using PassWraith.Data;
using PassWraith.Forms;
using PassWraith.Utilities;
using System;
using System.Windows.Forms;

namespace PassWraith
{
    internal static class Program
    {

        private static IServiceProvider serviceProvider;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            var schedulerService = serviceProvider.GetRequiredService<SchedulerService>();
            schedulerService.StartRemoveDeletedCredentialsJob();

            var passWraithContext = serviceProvider.GetRequiredService<IPassWraithContext>();
            if (passWraithContext.IsUserRegistered())
            {
                Application.Run(serviceProvider.GetRequiredService<Login>());
            }
            else
            {
                Application.Run(serviceProvider.GetRequiredService<Register>());
            }

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.LogException(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Logger.LogException(ex);
            }
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPassWraithContext, PassWraithContext>();
            services.AddScoped<SchedulerService>();
            services.AddScoped<PassWraith>();
            services.AddScoped<Register>();
            services.AddScoped<Login>();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
