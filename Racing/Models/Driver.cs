using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
    public class Driver
    {
        public string NickName { get; set; }

        public int Prizes { get; set; }
        public int NumberOfRace { get; set; }
        public override string ToString()
        {
            return $"Driver Nick: {NickName} | Number Of Races: {NumberOfRace} | Prizes: {Prizes}";
        }
    }
}
