using ClientAquariumApp.Abstractions.Models;
using ClientAquariumApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace ClientAquariumApp.Configuration
{
    public static class DIContainer
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static AppSettings? AppSettings { get; private set; }

        public static void Configure(IConfiguration configuration)
        {
            var services = new ServiceCollection();

            // Добавьте регистрацию ваших служб и классов здесь
            // services.AddSingleton<IAppSettings, AppSettings>(); // an example

            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));


            ServiceProvider = services.BuildServiceProvider();

            AppSettings = ServiceProvider.GetService<IOptions<AppSettings>>()?.Value;
        }
    }
}
