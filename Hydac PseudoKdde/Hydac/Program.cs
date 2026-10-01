using System.Drawing;

namespace Hydac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\u001b[32m:) \u001b[33m:|\u001b[31m:( \u001b[0m");
            int smileyChoice = int.Parse(Console.ReadLine());
            
            switch (smileyChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\u001b[32m:) \u001b[0m");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\u001b[33m:| \u001b[0m");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\u001b[31m:( \u001b[0m");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
            Console.ReadLine();
            //Menu valg

            //Tager valget, og viser valget


            //hvis medarbejder
            //Indstast medarbejder kode ****
            //confirmer medarbejder med display af navn
            //vælg ankomst/afgang/book møde
            //hvis ankomst
            //vælg smiley, og system melder god dag
            //hvis afgang, meld god dag, og timerne bliver registreret
            //hvis book møde, modtag liste over ledige lokaler.
            //meld lokale, antal deltagere, og hvilke deltagere
            //system gemmer lokalestatus, og opdaterer lokalestatus.


            //hvis valgt gæst
            //Indstast navn og firma "xxx" "xxx"
            //Viser møde information
            //system melder god dag, og receptionen får besked om at gæst er ankommet
        }
    }
}
