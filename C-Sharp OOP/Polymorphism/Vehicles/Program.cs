using System;
using Vehicles.Interfaces;
using Vehicles.Models;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            int numbersOfCommand = int.Parse(Console.ReadLine());
            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            

            for (int i = 0; i < numbersOfCommand; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0]; // ako e Drive -> comand[2] = dist;
                string vehicle = command[1];
                double distOrLiters = double.Parse(command[2]);

                switch (action)
                {
                    case "Drive":
                        if (vehicle == "Car")
                        {
                            car.Drive(distOrLiters);
                        }
                        else
                        {
                            truck.Drive(distOrLiters);
                        }
                        break;

                    case "Refuel":
                        if (vehicle == "Car")
                        {
                            car.Refuel(distOrLiters);
                        }
                        else
                        {
                            truck.Refuel(distOrLiters);
                        }
                        break;
                }


            }

            Console.WriteLine($"Car: {Math.Round( car.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Truck: {Math.Round( truck.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}
