using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAquariumApp.ViewModels
{
    public class JournalPostModel
    {
        public int? FishTankID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? DateTime { get; set; }

        public List<int> MaintenanceTypes { get; set; } = new List<int>();

    }
 
}
