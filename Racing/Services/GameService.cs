using Racing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess
{
    public class GameService
    {
        private Random _random = new Random();
        public bool StartDriving(Car driver,Car opponent)
        {
           
            driver.Speed = 0;
            opponent.Speed = 0;

            for (int i = 0; i < driver.MaxSpeed; i+=10)
            {
                driver.Speed += _random.Next(0, 20);
            }

            for (int i = 0; i < opponent.MaxSpeed; i += 10)
            {
                opponent.Speed += _random.Next(0, 20);
            }

            if (driver.Speed > opponent.Speed)
                return true;
            return false;


        }
    }
}
