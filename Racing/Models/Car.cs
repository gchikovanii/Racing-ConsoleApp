using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Models
{
    public class Car
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double MaxSpeed { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public static List<Car> ListOfCars = new List<Car>() 
        {
            new Car() { Name ="Jeep",MaxSpeed = 140,Speed = 0.0,Price=19000 ,Type = "Suv"},
            new Car() { Name ="Mitsubishi Outlander",MaxSpeed = 160,Speed = 0.0,Price=12000 ,Type = "Suv"},
            new Car() { Name ="Nissan Sentra",MaxSpeed = 180,Speed = 0.0,Price=15000 ,Type = "Sedan"},
            new Car() { Name ="Toyota Prius C",MaxSpeed = 190,Speed = 0.0,Price=7000 ,Type = "Sedan"},
            new Car() { Name ="Hyundai Elantra",MaxSpeed = 185,Speed = 0.0,Price=17000 ,Type = "Sedan"},
            new Car() { Name ="Hyundai Sonata",MaxSpeed = 220,Speed = 0.0,Price=12000 ,Type = "Sedan"},
            new Car() { Name ="Toyota Camry",MaxSpeed = 240,Speed = 0.0,Price=22000 ,Type = "Sporsts Car"},
            new Car() { Name ="Tesla Model X",MaxSpeed = 350,Speed = 0.0,Price=212000 ,Type = "Sporsts Car"},
            new Car() { Name ="Porsche 911",MaxSpeed = 340,Speed = 0.0,Price=320000 ,Type = "Sporsts Car"},
            new Car() { Name ="Lamborghini",MaxSpeed = 320,Speed = 0.0,Price=300000 ,Type = "Suv"},
            new Car() { Name ="Hyundai Sonata",MaxSpeed = 240,Speed = 0.0,Price=5000 ,Type = "Sedan"},
            new Car() { Name ="Honda Civic",MaxSpeed = 230,Speed = 0.0,Price=9000 ,Type = "Sedan"},
        };

        public override string ToString()
        {
            return $"Car Name: {Name} | Max Speed: {MaxSpeed} | Type: {Type} | Price: {Price}";
        }

    }
}
