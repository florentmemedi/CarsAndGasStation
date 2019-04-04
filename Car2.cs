using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndGasStation
{
    public partial class Car
    {
        public Car(string brand, string model, string color, int fuel, bool haveKeys, bool isDrivable)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Fuel = fuel;
            HaveKeys = haveKeys;
            IsDrivable = isDrivable;
        }

        partial void StartCar()
        {
            if (HaveKeys == true)
            {
                Console.WriteLine("You can start a car");
            }
            else
            {
                Console.WriteLine("You can't start a car");
            }
            IsDrivable = true;
        }

        partial void StartLights()
        {
            if (IsDrivable == true)
            {
                Console.WriteLine("You can start lights");
            }
            else
            {
                Console.WriteLine("You can't start lights");
            }
            
        }
    }
}
