using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAquariumApp.ViewModels
{
    public class FishTankGridModel: FishTankBaseModel
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int Depth { get; set; }

        public int VolumeOfWater { get; set; }

        public int FishCount { get; set; }

        public bool IsLightning { get; set; }

        public bool IsPump { get; set; }

        public bool IsHeater { get; set; }

        public bool IsFilters { get; set; }

        public FishTankGridModel()
        {
            
        }

        public FishTankGridModel(int width, int height, int depth)
        {
            Width = width; Height = height; Depth = depth;
        }

        public override string ToString()
        {
            return $"{Width}x{Height}x{Depth}";
        }
    }
}

