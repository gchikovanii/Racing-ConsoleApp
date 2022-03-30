using Racing.Data;
using Racing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess
{
    public class DriverService
    {
        public Driver GetDriver(string name)
        {
            var driver = ListData.ListOfDrivers.FirstOrDefault(i => i.NickName == name);
            if(driver != null)
                return driver;
            return null;
        }
        public Balance GetDriverBalance(string name)
        {
            var balance = ListData.ListOfBalances.FirstOrDefault(i => i.NickName == name);
            if (balance != null)
                return balance;
            return balance;
        }

        public Garage GetGarage(string name)
        {
            var garage = ListData.ListOfGarages.FirstOrDefault(i => i.NickName == name);
            if (garage != null)
                return garage;
            return garage;
        }

    }
}
