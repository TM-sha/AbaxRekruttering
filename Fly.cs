using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Fly : FlyOgBåt
    {
        public int VingeSpenn { get; }
        public int LasteEvne { get; }
        public int Egenvekt { get; }
        public string Klasse { get; }

        public Fly(string regNr, int effekt, int vingeSpenn, int lasteEvne, int egenvekt, string klasse) : base(regNr, effekt)
        {
            VingeSpenn = vingeSpenn;
            LasteEvne = lasteEvne;
            Egenvekt = egenvekt;
            Klasse = klasse;
        }

        public override string PrintInfo()
        {
            string baseInfo = base.PrintInfo() ?? "";

            return ($"Fly\n" +
                    $"{baseInfo}" +
                    $"Vingespenn: {VingeSpenn}m\n" +
                    $"Lasteevne : {LasteEvne}tonn\n" +
                    $"Egenvekt: {Egenvekt}tonn\n" +
                    $"Klasse: {Klasse}");
        }

        public override string Run()
        {
            return ($"Fly med regnr: {RegNr} tar av og flyr nordover..\n");
        }
    }
}
