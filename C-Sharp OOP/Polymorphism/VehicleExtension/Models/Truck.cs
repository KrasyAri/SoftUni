using System;
using System.Collections.Generic;
using System.Text;
using VehicleExtension.Interfaces;

namespace VehicleExtension.Models
{
    public class Truck : IVehicle
    {
        private double fuelConsumptionIncrease = 1.6;
        private double fuelQuantity;

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value <= this.TankCapacity)
                {
                    this.fuelQuantity = value;
                }
                else
                {
                    this.fuelQuantity = 0;
                }
            }
        }

        public double FuelConsumptionPerKm { get; set; }
        public double TankCapacity { get; set; }

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;

        }


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
            if (this.FuelQuantity + totalLiters < TankCapacity)
            {
                this.FuelQuantity += totalLiters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
