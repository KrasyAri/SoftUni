using System;
using VehicleExtension.Interfaces;
using VehicleExtension.Models;

namespace VehicleExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            
            string[] truckInfo = Console.ReadLine().Split();
           
            string[] busInfo = Console.ReadLine().Split();
          

            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            IVehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int numbersOfCommand = int.Parse(Console.ReadLine());

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

                        else if (vehicle == "Truck")
                        {
                            truck.Drive(distOrLiters);
                        }
                        else
                        {
                            bus.Drive(distOrLiters);
                        }
                        break;

                    case "Refuel":
                        if (vehicle == "Car")
                        {
                            if (distOrLiters <=0)
                            {
                                Console.WriteLine("Fuel must be a positive number");
                            }
                            else
                            {
                                car.Refuel(distOrLiters);
                            }
                            
                        }

                        else if(vehicle == "Truck")
                        {
                            if (distOrLiters <= 0)
                            {
                                Console.WriteLine("Fuel must be a positive number");
                            }
                            else
                            {
                                truck.Refuel(distOrLiters);
                            }
                            
                        }
                        else
                        {
                            bus.Refuel(distOrLiters);
                        }
                        break;

                    case "DriveEmpty":
                        
                        Bus newbus = bus as Bus;

                        newbus.DriveEmpty(distOrLiters);

                        bus = newbus;

                        break;
                }

            }

            Console.WriteLine($"Car: {Math.Round(car.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Bus: {Math.Round(bus.FuelQuantity, 2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}
