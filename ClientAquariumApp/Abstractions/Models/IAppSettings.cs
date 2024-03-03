using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAquariumApp.Abstractions.Models
{
    public interface IAppSettings
    {
        public string AppName { get; }

        public string AppVersion { get; }

        public string ApiUrl { get; }
    }
}
