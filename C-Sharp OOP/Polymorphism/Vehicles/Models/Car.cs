using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public class Car : IVehicle
    {
        private double fuelConsumptionIncrease = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumptionPerKm { get; set; }


        public void Drive(double distance)
        {
            double totalConsumped = (this.FuelConsumptionPerKm + this.fuelConsumptionIncrease) * distance;

            if (this.FuelQuantity >= totalConsumped)
            {
                this.FuelQuantity -= totalConsumped;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
