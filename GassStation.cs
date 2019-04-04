using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndGasStation
    {
        public static class GasStationn
        {
            public static void Refill(Car c)
            {
                if (c.Fuel == 65)
                {
                    Console.WriteLine("Your fuel is to maximum");
                }
            else
            {
                Console.WriteLine("You have enough space to refuel your car");
            }
        }

            public static void PumpUpTires(Car c)
            {
                Console.WriteLine("The car now is in a good state");
                c.IsDrivable = true;
            }
        }
    }
