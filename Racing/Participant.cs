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
    public class Participant
    {
        private DriverService _driverService = new DriverService();
        private RegisterService _registerService = new RegisterService();
        public void RegisterParticipant()
        {
            string nickName;
            bool isCheked = false;
            WriteLine("Welcome to Race Club ,please go through registration!");
            do
            {
                WriteLine("Enter participant NickName:");
                nickName = ReadLine();
                isCheked = _registerService.ChekNickName(nickName);

                if (isCheked)
                {
                    if (string.IsNullOrEmpty(nickName))
                        WriteLine("Please Enter Nick Name!");
                    else
                    {
                        var participant = _driverService.GetDriver(nickName);
                        if (participant == null)
                        {
                            Driver driver = new Driver { NickName = nickName, NumberOfRace = 0, Prizes = 0 };
                            ListData.ListOfDrivers.Add(driver);
                            ListData.ListOfBalances.Add(new Balance { NickName = driver.NickName, Amount = 0 });
                            ListData.ListOfGarages.Add(new Garage
                            {
                                Cars = new List<Car>
                            {
                                new Car { Name ="Jeep",MaxSpeed = 165,Speed = 0.0,Price=19000 ,Type = "Suv"},

                            },
                                NickName = driver.NickName
                            });
                            WriteLine($"Welcome to Race World {driver.NickName}");
                        }
                        else
                            WriteLine("Participant with this name has alredy registered!");
                    }
                }
                else
                    WriteLine("Use correct name withou special characters!");
            }
            while (string.IsNullOrWhiteSpace(nickName) || isCheked != true);
        }

        public void PrintInfoAboutParticipant()
        {
            WriteLine("Enter NickName:");
            string nickName = ReadLine();

            var driver = _driverService.GetDriver(nickName);

            if (driver != null)
                WriteLine($"Nick Name is:{driver.NickName} \n Prize-winning places: {driver.Prizes}");
            else
                WriteLine("Participant with this Nick Name doesn't exsits!");
        }

        public void PrintBalance()
        {
            WriteLine("Enter NickName:");
            string nickName = ReadLine();

            var balance = _driverService.GetDriverBalance(nickName);

            if (balance != null)
            {
                WriteLine($"{balance.NickName} total balance is - {balance.Amount}$");
            }
            else
                WriteLine("Participant with this Nick Name doesn't exsits!");
        }

        public void PrintGarage()
        {
            WriteLine("Enter NickName:");
            string nickName = ReadLine();

            var garage = _driverService.GetGarage(nickName);

            if (garage != null)
            {
                foreach (var item in garage.Cars)
                {
                    WriteLine(item.ToString());
                }
            }
            else
                WriteLine("Participant with this Nick Name doesn't exsits!");

        }


    }
}
