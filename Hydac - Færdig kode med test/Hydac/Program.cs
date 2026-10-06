using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace Hydac
{
    internal class Program
    {
        private static Worker[] workers = new Worker[100];
        private static int workerCount = 0;

        static void Main(string[] args)
        {
            LoadWorkers();
            

            int choice;
            do
            {
                //Menu printes
                Console.Clear();
                Console.WriteLine("Hydac");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Medarbejder");
                Console.WriteLine("2. Gæst");
                Console.WriteLine("0. Afslut");
                Console.WriteLine();

                //TryParse, så evt ulovlige inputs bliver -1
                if (!int.TryParse(Console.ReadLine(), out choice))
                    choice = -1;
                
                switch (choice)
                {
                    case 1:
                        //Henviser til EmployeeMenu
                        EmployeeMenu();
                        break;
                    case 2:
                        Console.WriteLine("Gæst valgt");
                        //Ikke lavet
                        Console.WriteLine("Funktion coming soon...");
                        break;

                        //Case 0: program slutter
                    case 0:
                        Console.WriteLine("God dag");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
                Console.WriteLine("Tryk enter for at fortsætte");
                Console.ReadLine();


            } while (choice != 0);



        }
        private static void EmployeeMenu()
        {
            int employeeNumber;
            Console.Write("Indtast medarbejder nummer: ");
            int.TryParse(Console.ReadLine(), out employeeNumber);
            //finder medarbejder udfra nummer, med FindWorker
           Worker worker = FindWorker(employeeNumber);
            if (worker == null)
            {
                Console.WriteLine("Ugyldigt nummer");
                return;
            }
            Console.Clear();
            Console.WriteLine($"Velkommen, {worker.Name}!");
            Console.WriteLine();
            Console.WriteLine("1. Ankomst");
            Console.WriteLine("2. Afgang");
            Console.WriteLine("3. Book møde");
            Console.WriteLine();
            int choice;
            int smileyChoice;
            if (!int.TryParse(Console.ReadLine(), out choice))
                choice = -1;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Valgt: Ankomst");
                    CheckInWorker();
                    smileyChoice = int.Parse(Console.ReadLine());
                    switch (smileyChoice)
                    {
                        case 1:
                            Console.WriteLine("\u001b[32m:)\u001b[0m");
                            Console.WriteLine($"God Dag {worker.Name}");
                            break;
                        case 2:
                            Console.WriteLine("\u001b[33m:|\u001b[0m");
                            Console.WriteLine($"God Dag {worker.Name}");
                            break;
                        case 3:
                            Console.WriteLine("\u001b[31m:(\u001b[0m");
                            Console.WriteLine($"God Dag {worker.Name}");
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Valgt: Afgang");
                    Console.WriteLine($"God Dag {worker.Name}");
                    break;
                case 3:
                    Console.WriteLine("Valgt: Book møde");
                    Console.WriteLine("Funktion coming soon...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }

        private static void CheckInWorker()
        {
            Console.WriteLine("1. \u001b[32m:)\u001b[0m  2. \u001b[33m:|\u001b[0m  3. \u001b[31m:(\u001b[0m");

        }

        private static void LoadWorkers()
        {
            //Eksternt dokument, hvor nye medarbejdere kan oprettes, og fjernes
            StreamReader reader = new StreamReader("workers.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                //Gemmer medarebjder nummer og navn seperat.
                string[] parts = line.Split(';');
                int idNumber = int.Parse(parts[0]);
                string name = parts[1];
                workers[workerCount] = new Worker(idNumber, name);
                workerCount++;
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private static Worker FindWorker(int idNumber)
        {
            //finder medarbejder udfra indtastet tal
            for (int i = 0; i < workerCount; i++)
            {
                if (workers[i].IdNumber == idNumber)
                {
                    return workers[i];
                }
            }
            return null;
        }
    }
}
