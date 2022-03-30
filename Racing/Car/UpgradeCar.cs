using Racing.Data;
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
    public class UpgradeCar
    {
        private CarService _carService = new CarService();
        private DriverService _driverService = new DriverService();
        private SparePartService _partService = new SparePartService();


        public void AddCarParts()
        {
            WriteLine("Enter NickName");
            string nickName = ReadLine();

            var driver = ListData.ListOfDrivers.FirstOrDefault(i => i.NickName == nickName);
            if (driver != null)
            {
                var balanceOfDriver = _driverService.GetDriverBalance(nickName);
                if (balanceOfDriver != null)
                {
                    WriteLine("Enter the name of spare part that you want to add");
                    var sparePart = ReadLine();

                    var parts = _partService.GetParts(sparePart);
                    if (parts != null)
                    {
                        if (parts.NumberOfImprovments < 4)
                        {
                            if (balanceOfDriver.Amount >= Convert.ToDouble(parts.Price))
                            {
                                WriteLine("Enter name of your vehicle that you want to upgrade:");
                                var upgradeCar = ReadLine();
                                var car = _carService.GetCars(nickName, upgradeCar);

                                if (car != null)
                                {
                                    WriteLine($"Your Car was Improved! Maximum Speed was:{car.Speed}");
                                    car.MaxSpeed += ((car.MaxSpeed * parts.PercentageOfImprovment) / 100);
                                    WriteLine($"Now Maximum Speed is:{car.Speed}");
                                    parts.NumberOfImprovments++;
                                }
                            }
                            else
                                WriteLine("You don't have enough money!");
                        }
                        else
                            WriteLine("You ran out of attempts to upgrade your car!");
                    }
                    else
                        WriteLine("There is no such parts in stock!");
                }
                else
                    WriteLine("We can't found participant with exsiting name");
            }
            

        }


        public static void PrintInfoAboutSpareParts()
        {
            WriteLine("You can see the list of spare parts that you can Improve:\n" +
                "1.Wheel\n" +
                "2.Engine\n" +
                "3.Nitro\n" +
                "4.Transmission");
        }


    }
}
