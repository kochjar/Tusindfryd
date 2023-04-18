using Tusindfryd.controller;

namespace Tusindfryd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Controller controller = new Controller();

            controller.TilføjDrivhus("Drivhus 1");
            controller.TilføjDrivhus("Drivhus 2");

            controller.TilføjProduktionsbakke("Drivhus 1", "P1", 10, new DateTime(2019, 1, 1), 5, 20, false);
            controller.TilføjProduktionsbakke("Drivhus 1", "P2", 12, new DateTime(2019, 4, 1), 1, 15, false);
            controller.TilføjProduktionsbakke("Drivhus 2", "P3", 12, new DateTime(2020, 4, 1), 1, 15, false);

            controller.TilføjMedarbejder("WW", "Walter White");
            controller.TilføjMedarbejder("PF", "Peter File");
            controller.TilføjMedarbejder("ME", "Mike Oxlong Ehrmantraut");

            controller.TilføjSort("Lily of the valley", 50, new TimeSpan(10, 0, 0), "P2");
            controller.TilføjOptælling("P2", "O1", new DateTime(2022, 1, 1), 22, 20, 10, "WW");

            var drivhuse = controller.HentAlleDrivhuse();
            var medarbejdere = controller.HentAlleMedarbejdere();

            foreach (var drivhus in drivhuse)
            {
                foreach (var produktionsbakke in drivhus.Produktionsbakker)
                {
                    Console.WriteLine(drivhus.Id);
                    Console.WriteLine(produktionsbakke.Navn);
                    Console.WriteLine(produktionsbakke.Startdato);
                    if (produktionsbakke.Optælling != null)
                    {
                        Console.WriteLine(produktionsbakke.Optælling.Medarbejder.Initialer);
                    }
                    if (produktionsbakke.Sort != null)
                    {
                        Console.WriteLine(produktionsbakke.Sort.Navn);
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("MEDARBEJDERE: ");
            foreach (var medarbejder in medarbejdere)
            {
           
                Console.WriteLine($"{medarbejder.Initialer}: {medarbejder.Navn}");
            }


        }
    }
}