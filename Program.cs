using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndGasStation
{
    public static class GasStation
    {
     public static void Refill (Car c)
        {
          if (c.Fuel >= 65)
            {
                Console.WriteLine();
            }
        }
        public static void PumpUpTires(Car c)
        {
            Console.WriteLine("The car now is in the good state");
            c.IsDrivable = true;
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Seat", "Leon", "Gray", 65, false, false);
           
            Console.ReadLine();
        }
    }
}
