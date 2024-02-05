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
