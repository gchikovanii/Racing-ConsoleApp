using Racing.Models;
using Racing.Servicess;
using Racing.Servicess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Racing
{
    public class Lottery
    {
        private DriverService _driverService = new DriverService();
        private LotteryService _lotteryService = new LotteryService();

        public static void PrintLotteryPrize()
        {
            WriteLine("Only 3% of people can win this new TESLA MODEL S!" +
                "You can practicipate if you have to attended on 5 or more races! Good Luck!");
        }

        public void ParticipateInLottery()
        {
            WriteLine("Enter NickName");
            string nickName = ReadLine();

            string carName = "Tesla Model S";
            var garage = _driverService.GetGarage(nickName);
            var car = garage.Cars.FirstOrDefault(i => i.Name == carName);

            if (car == null)
            {
                var driver = _driverService.GetDriver(nickName);
                if (driver != null)
                {
                    var lucky = _lotteryService.PlayLottery();
                    if (lucky && driver.NumberOfRace <= 5)
                    {
                        if (garage != null)
                        {
                            Car newCar = new Car { Name = carName, Speed = 0.0, MaxSpeed = 390, Price = 40000, Type = "Sedan" };
                            garage.Cars.Add(newCar);
                            WriteLine("Congratulations!!! You won new model Tesla S!");
                        }
                        else
                            WriteLine("You lost, not today buddy!");
                    }
                    else
                        WriteLine("Sorry, you can't take part in. Firstly you have to attended on 5 or more races!");
                }
            }
            else
                WriteLine("You once won that car!");


        }
        
    }
}
