using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndGasStation
{
    public static class ExtensionMethod
    {
        public static void Drive(this Car c, string place)
        {
            if (c.IsDrivable)
            {
                Console.WriteLine($"The car is driving to {place}");
                c.Fuel -= 15;
            }
        }
        public static string GetCarStats(this Car c)
        {
            return $"Car's inforamtion:\n" +
                   $"Brand: {c.Brand}\n" +
                   $"Model: {c.Model}\n" +
                   $"Color: {c.Color}\n" +
                   $"Fuel: {c.Fuel}\n" +
                   $"Driving status: {(c.IsDrivable ? "You can drive the car" : "Sorry, you can't drive the car")}";
        }
    }
}
