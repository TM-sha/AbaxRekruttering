using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Båt : FlyOgBåt
    {
        public int MaxSpeed { get; }
        public int BruttoTonnasje { get; }

        public Båt(string regNr, int effekt, int maxSpeed, int bruttoTonnasje) : base(regNr, effekt)
        {
            MaxSpeed = maxSpeed;
            BruttoTonnasje = bruttoTonnasje;
        }

        public override string PrintInfo()
        {
            string baseInfo = base.PrintInfo() ?? "";

            return ($"Båt\n" +
                    $"{baseInfo}" +
                    $"Maksfart: {MaxSpeed} knop\n" +
                    $"TU (Tonnage Units): {BruttoTonnasje}kg");
        }

        public override string Run()
        {
            return ($"Båt med regnr: {RegNr} farer av sted.."); 
        }
    }
}
