using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicleList = { "SUV", "Motorbike", "Van", "Sedan" };


            Console.Write("Enter plater number: ");
            string plateNumber = Console.ReadLine();

            for (int i = 0; i < vehicleList.Length; ++i)
            {
                Console.WriteLine("{0}) {1}", i + 1, vehicleList[i]);
            }

            Console.Write("Choose vehicle type (1-4):");
            int vehicleType = int.Parse(Console.ReadLine());

            Console.Write("Enter vehicle brand: ");
            string brand = Console.ReadLine();

            ParkingManager car = new ParkingManager(plateNumber, brand, vehicleList[vehicleType - 1]);

            switch (vehicleList[vehicleType - 1])
            {
                case "Motorbike":
                    car.FlagDown = 20;
                    break;

                case "SUV":
                case "Van":
                    car.FlagDown = 40;
                    break;

                case "Sedan":
                    car.FlagDown = 30;
                    break;

            }

          
            car.printDetails();

            Console.Write("Parkout time: ");
            DateTime parkout = Convert.ToDateTime(Console.ReadLine());

            car.calculateParkOut(parkout);
            Console.ReadKey();

            // WriteLine("{0}\n{1}\n{2}\n", plateNumber, vehicleType, brand);

        }
    }
}
