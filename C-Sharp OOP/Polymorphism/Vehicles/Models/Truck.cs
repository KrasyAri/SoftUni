using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public class Truck : IVehicle
    {
        private double fuelConsumptionIncrease = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
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
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            double totalLiters = (95 * liters) / 100;
            this.FuelQuantity += totalLiters;
        }
    }
}
