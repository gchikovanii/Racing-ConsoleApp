using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess.Services
{
    public class LotteryService
    {
        Random random = new Random();
        public bool PlayLottery()
        {
            var number = random.Next(0,100);
            if(number >= 1 && number <=3)
                return true;
            return false;
        }
    }
}
