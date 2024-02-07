using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAquariumApp.ViewModels
{
    public class GetJournalModel
    {            
        public string Name { get; set; } = string.Empty;

        //public string Description { get; set; } = string.Empty;

        public DateTime? DateTime { get; set; }

    }
}
