using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal interface IVehicle
    {
        string RegNr { get; }
        int Effekt { get; }
        void PrintInfo();
        void Run();
    }
}
