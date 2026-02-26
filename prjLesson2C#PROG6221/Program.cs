namespace prjLesson2C_PROG6221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Reece = new Pets("Lilo", "Runs away often", "Tabby cat", "cat");
            var Jarred = new Pets("Chester", "Will kill you", "Mainecoon", "cat");
            Reece.Display();
            Console.WriteLine("**********************************");
            Console.WriteLine(Jarred.ToString());
            Console.WriteLine("**********************************");
            var Lana = new Dogs("Titan","a few screws are loose","Staffy", true);

            Console.WriteLine(Lana.ToString());
            Console.WriteLine("**********************************");

            var Jasveer = new Cats("Lusifer", "Will bite Jarred", "Mix", "Black and white");
            Console.WriteLine(Jasveer.ToString());
            Console.WriteLine("**********************************");
            Jasveer.Display();
            Console.WriteLine("**********************************");
            var Kreal = new Brids("Miles", "Best bird ever", "African grey", true, "Grey");
            Console.WriteLine(Kreal.ToString());

        }
    }
}
