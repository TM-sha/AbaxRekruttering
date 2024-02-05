using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Vehicle : IVehicle
    {
        public string RegNr { get; }
        public int Effekt { get; }
        public int MaksFart { get; }
        public int VingeSpenn { get; }
        public int LasteEvne { get; }
        public int Egenvekt { get; }
        public string? Klasse { get; }
        public int BruttoTonnasje { get; }
        public string? Farge { get; }
        public VehicleType Type { get; }

        // Constructor for Båt
        public Vehicle(string regNr, int effekt, int maksFart, int bruttoTonnasje)
        {
            RegNr = regNr;
            Effekt = effekt;
            MaksFart = maksFart;
            BruttoTonnasje = bruttoTonnasje;
            Type = VehicleType.Båt;
        }

        // Constructor for Bil
        public Vehicle(string regNr, int effekt, int maksFart, string farge, string klasse)
        {
            RegNr = regNr;
            Effekt = effekt;
            MaksFart = maksFart;
            Type = VehicleType.Bil;
            Farge = farge;
            Klasse = klasse;
        }

        // Constructor for Fly
        public Vehicle(string regNr, int effekt, int vingeSpenn, int lasteEvne, int egenvekt, string klasse)
        {
            RegNr = regNr;
            Effekt = effekt;
            VingeSpenn = vingeSpenn;
            LasteEvne = lasteEvne;
            Egenvekt = egenvekt;
            Klasse = klasse;
            Type = VehicleType.Fly;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"*{Type}*");
            Console.WriteLine($"Regnr: {RegNr}\n" +
                              $"Effekt: {Effekt}kw");

            switch (Type)
            {
                case VehicleType.Bil:
                    Console.WriteLine($"Toppfart: {MaksFart}km/t\n" +
                                      $"Farge: {Farge}\n" +
                                      $"Klasse: {Klasse}\n");
                    break;
                case VehicleType.Fly:
                    Console.WriteLine($"Vingespenn: {VingeSpenn}m\n" +
                                      $"Lasteevne: {LasteEvne}tonn\n" +
                                      $"Egenvekt: {Egenvekt}tonn\n" +
                                      $"Klasse: {Klasse}\n");
                    break;
                case VehicleType.Båt:
                    Console.WriteLine($"Toppfart: {MaksFart}knop\n" +
                                      $"TU (Tonnage Units): {BruttoTonnasje}kg\n");
                    break;
            }
        }

        public void Run()
        {
            Console.Write($"{Type} med regnr: {RegNr}");
            Console.WriteLine(" kjører en tur\n");
        }

        internal enum VehicleType
        {
            Bil,
            Fly,
            Båt
        }
    }
}
