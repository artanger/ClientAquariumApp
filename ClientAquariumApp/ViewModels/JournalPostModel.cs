using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAquariumApp.ViewModels
{
    public class JournalPostModel : IdNameModel
    {
      

        public int? FishTankID { get; set; }       

        public DateTime? DateTime { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public List<int> MaintenanceTypes { get; set; } = new List<int>();

        public string MaintenanceTypeIntIDs { get; set; } = string.Empty;

    }   

}
