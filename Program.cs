namespace AbaxRekruttering
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Init();
        }

        private static void Init()
        {
            RunCars();

            RunPlane();

            RunBoat();
        }

        private static void RunCars()
        {
            Car bil1 = new Car("Bil 1","NF123456", 147, 200, "grønn", "Lett kjøretøy");
            Car bil2 = new Car("Bil 2", "NF654321", 150, 195, "blå", "Lett kjøretøy");
            Ask(bil1.PrintInfoCars(), bil2.PrintInfoCars());
            Ask(bil1.TakeARide());
            CompareCars(bil1, bil2);
        }

        private static void CompareCars(Car bil1, Car bil2)
        {
            if (!bil1.IsEqual(bil2)) Console.WriteLine("Bilene er ikke av samme type.");
            else Console.WriteLine("Bilene er av samme type.");
        }

        private static void RunPlane()
        {
            Fly fly = new Fly("LN1234", 1000, 30, 2, 10, "Jetfly");
            Console.ReadKey();
            Console.Clear();
            Ask(fly.PrintInfo(), fly.Run());
        }

        private static void RunBoat()
        {
            Båt båt = new Båt("ABC123", 100, 30, 500);
            Ask(båt.PrintInfo(), båt.Run());
        }

        private static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine() ?? "";
        }

        private static string Ask(string question, string question2)
        {
            Console.WriteLine(question);
            Console.WriteLine();
            Console.WriteLine(question2);
            return Console.ReadLine() ?? "";
        }
    }
}