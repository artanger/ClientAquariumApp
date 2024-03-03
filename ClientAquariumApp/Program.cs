using ClientAquariumApp.Abstractions.Models;
using ClientAquariumApp.Configuration;
using ClientAquariumApp.Models;
using LiveChartsCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenTK;
using System.Configuration;

namespace ClientAquariumApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configuration = GetCustomAppSettinsConfiguration();

            DIContainer.Configure(configuration);

            Application.Run(new MainForm());
        }

        static IConfiguration GetCustomAppSettinsConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return configurationBuilder.Build();
        }
    }
}