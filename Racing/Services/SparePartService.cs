using Racing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess.Services
{
    public class SparePartService
    {
        public SparePart GetParts(string part)
        {
            var sparePart = SparePart.SpareParts.FirstOrDefault(x => x.Name == part);
            if(sparePart != null)
                return sparePart;
            return null;
        }
    }
}
