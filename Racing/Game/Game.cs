using Racing.Data;
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
    public class Game
    {
        private GameService _gameService = new GameService();
        private CarService _carService = new CarService();
        private DriverService _driverService = new DriverService();

        public void PrintAllCars()
        {
            foreach (var item in Car.ListOfCars.ToList())
            {
                WriteLine(item.ToString());
                WriteLine(new string('-', 30));
            }
        }

        public void StartRace()
        {
            WriteLine("Enter NickName");
            string nickName = ReadLine();

            var driver = ListData.ListOfDrivers.FirstOrDefault(i => i.NickName == nickName);
            if (driver != null)
            {
                WriteLine("Enter name of car:");
                string nameOfCar = ReadLine();
                var car = _carService.GetCars(nickName, nameOfCar);
                if (car != null)
                {
                    var balance = _driverService.GetDriverBalance(nickName);
                    var opponentCar = _carService.GetCarForOpponent(car);
                    WriteLine(new string('-', 30));
                    WriteLine($"Participant's Car is: {car.Name} \n Opponents Car is: {opponentCar.Name}");
                    WriteLine(new string('-', 30));


                    var winner = _gameService.StartDriving(car, opponentCar);
                    if (winner)
                    {
                        WriteLine($"Winner - {driver.NickName}");
                        balance.Amount += 500;
                        driver.Prizes += 1;
                    }
                    else
                        WriteLine("The winner is your Opponent!");
                }
                else
                    WriteLine("You don't have this car in your Garage!");
            }
            else
                WriteLine("Participant with given NickName hasn't found!");
        }


    }
}
