using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
    public class SparePart
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PercentageOfImprovment { get; set; }
        public int NumberOfImprovments { get; set; }

        public static List<SparePart> SpareParts = new List<SparePart>()
        {
            new SparePart(){Name="Wheel",Price=100,PercentageOfImprovment=5},
            new SparePart(){Name="Engine",Price=3500,PercentageOfImprovment=35},
            new SparePart(){Name="Nitro",Price=2000,PercentageOfImprovment=45},
            new SparePart(){Name="Transmission",Price=450,PercentageOfImprovment=10}
        };

    }
}
