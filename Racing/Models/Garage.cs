using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
    public class Garage
    {
        public string NickName { get; set; }

        public List<Car> Cars = new List<Car>();
    }
}
