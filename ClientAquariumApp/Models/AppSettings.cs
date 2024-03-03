using ClientAquariumApp.Abstractions.Models;

namespace ClientAquariumApp.Models
{
    public class AppSettings : IAppSettings
    {
        public string AppName { get; set; }

        public string AppVersion { get; set; }

        public string ApiUrl { get; set; }
    }
}
