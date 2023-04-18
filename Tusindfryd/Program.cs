using Tusindfryd.controller;

namespace Tusindfryd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MedarbejderRepository medarbejderRepo = new MedarbejderRepository();
            DrivhusRepository drivhusRepo = new DrivhusRepository(medarbejderRepo);

        }
    }
}