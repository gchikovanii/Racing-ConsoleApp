using Racing.Data;
using Racing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess.Services
{
    public class CarService
    {
        private Random random = new Random();

        public Car GetCars(string name,string nameOfCar)
        {
            var driver = ListData.ListOfDrivers.FirstOrDefault(i => i.NickName == name);
            if (driver != null)
            {
                var garage = ListData.ListOfGarages.FirstOrDefault(i => i.NickName == name);
                if(garage != null)
                {
                    var car = garage.Cars.FirstOrDefault(i => i.Name == nameOfCar);
                    return car;
                }
            }
            return null;
              
        }

        public Car GetCarForOpponent(Car driverCar)
        {
            Car car;
            if (driverCar.MaxSpeed >= 100 && driverCar.MaxSpeed <= 200)
                car = Car.ListOfCars[random.Next(0, 4)];
            else
                car = Car.ListOfCars[random.Next(5, 11)];

            return car;

        }



    }
}
