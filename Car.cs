using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Car
    {
        public string Name { get; private set; }
        public string RegNr { get; private set; }
        public int Power { get; private set; }
        public int MaxSpeed { get; private set; }
        public string Color { get; private set; }
        public string Class { get; private set; }

        public Car(string name, string regNr, int power, int maxSpeed, string color, string @class)
        {
            Name = name;
            RegNr = regNr;
            Power = power;
            MaxSpeed = maxSpeed;
            Color = color;
            Class = @class;
        }

        public string PrintInfoCars()
        {
            return ($"{Name}\n" +
                    $"{RegNr}\n" +
                    $"{Power}kw\n" +
                    $"{MaxSpeed} km/t\n" +
                    $"{Color}\n" +
                    $"{Class}\n");
        }

        public bool IsEqual(Car otherCar)
        {
            if (otherCar is Car car)
            {
                return (RegNr == car.RegNr);
            }

            return false;
        }

        public string TakeARide()
        {
            return ($"{RegNr} tar seg en kjøretur.");
        }
    }
}
