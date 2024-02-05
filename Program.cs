using static AbaxRekruttering.Vehicle;

namespace AbaxRekruttering
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Run();
        }

        private static void Run()
        {
            List<Vehicle> vehicles = new()
            {
                new Vehicle("NF123456", 147, 200, "Grønn", "Lett Kjøretøy"),
                new Vehicle("NF654321", 150, 195, "Blå", "Lett Kjøretøy"),
                new Vehicle("LN1234", 1000, 30, 2, 10, "Jetfly"),
                new Vehicle("ABC123", 100, 30, 500)
            };

            Vehicle bilInfo = null;
            int index = 0;
            foreach (Vehicle vehicle in vehicles)
            {

                if (index == 0) bilInfo = vehicle;
                vehicle.PrintInfo();
                if (index == 1)
                {
                    Console.WriteLine(vehicles[0].RegNr == vehicles[1].RegNr
                        ? "Bilene er av samme type\n"
                        : "Bilene er ikke av samme type\n");
                }

                if (index == 2)
                {
                    vehicle.Run();
                    bilInfo.Run();
                }
                index++;
            }
        }
    }
}
//Oppgaven - AbaxRekruttering
//Skriv et konsoll-program i C# som kan:
//Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km/t, grønn farge av typen lett kjøretøy. 
//Printe informasjon om en annen bil (bil 2) med reg. nr NF654321, 150kw effekt, maksfart 195km/t, blå farge og av typen lett kjøretøy 
//Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet 
//Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly 
//Konsollprogrammet skal be flyet om å fly og printe dette i konsollet. 
//Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet     
//Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.
