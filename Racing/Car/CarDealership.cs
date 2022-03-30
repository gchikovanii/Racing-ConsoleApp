using Racing.Models;
using Racing.Servicess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Racing
{
    public class CarDealership
    {
        private DriverService _driverService = new DriverService();
        public void BuyCar()
        {
            WriteLine("Enter NickName");
            string nickName = ReadLine();

            var driver = _driverService.GetDriver(nickName);
            if(driver != null)
            {
                var balance = _driverService.GetDriverBalance(nickName);
                if (balance != null)
                {
                    WriteLine("Enter the name of car that you want to purchase");
                    var carName = ReadLine();
                    var car = Car.ListOfCars.FirstOrDefault(i => i.Name == nickName);
                    var garage = _driverService.GetGarage(nickName);

                    if (car != null)
                    {
                        if (balance.Amount >= Convert.ToDouble(car.Price))
                        {
                            garage.Cars.Add(car);
                            balance.Amount -= Convert.ToDouble(car.Price);
                            WriteLine("You successfully purchased Car!");
                        }
                        else
                            WriteLine("You don't have enough money!");
                    }
                    else
                        WriteLine("We can't find this car!");
                }
                else
                    WriteLine("Problem with money Account!");
            }
            else
                WriteLine("There is no driver with this nick");


        }

    }
}
