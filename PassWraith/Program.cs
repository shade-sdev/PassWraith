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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();

            var passWraithContext = serviceProvider.GetRequiredService<IPassWraithContext>();
            if (passWraithContext.IsUserRegistered())
            {
                Application.Run(serviceProvider.GetRequiredService<Login>());
            } else
            {
                Application.Run(serviceProvider.GetRequiredService<Register>());
            }
           
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPassWraithContext, PassWraithContext>();
            services.AddScoped<PassWraith>();
            services.AddScoped<Register>();
            services.AddScoped<Login>();
            services.AddScoped<PasswordHelper>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
