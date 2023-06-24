using Microsoft.Extensions.DependencyInjection;
using PassWraith.Data;
using System;
using System.Windows.Forms;

namespace PassWraith
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPassWraithContext, PassWraithContext>();
            var serviceProvider = services.BuildServiceProvider();
            var serviceA = serviceProvider.GetService<IPassWraithContext>();
 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PassWraith(serviceA));
        }
    }
}
