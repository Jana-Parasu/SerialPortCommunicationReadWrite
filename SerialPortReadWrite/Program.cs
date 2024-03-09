using Microsoft.Extensions.DependencyInjection;
using SerialPortReadWrite.Services;
using SerialPortReadWrite.Services.DIInterfaces;
using System;
using System.Windows.Forms;

namespace SerialPortReadWrite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddSingleton<ISerialPortManager, SerialPortManager>();
            services.AddTransient<HomeWindow>();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<HomeWindow>());
            }
        }
    }
}
