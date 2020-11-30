using System;
using System.Collections.Generic;
using System.Text;
using VehicleExtension.Interfaces;

namespace VehicleExtension.Models
{
    public class Bus : IVehicle
    {
        private double fuelConsumptionIncrease = 1.4;
        private double fuelQuantity;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            
        }

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

        public void Drive(double distance)
        {
            double totalConsumped = (this.FuelConsumptionPerKm + this.fuelConsumptionIncrease) * distance;

            if (this.FuelQuantity >= totalConsumped)
            {
                this.FuelQuantity -= totalConsumped;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            double totalConsumpedEmpty = this.FuelConsumptionPerKm * distance;

            if (this.FuelQuantity >= totalConsumpedEmpty)
            {
                this.FuelQuantity -= totalConsumpedEmpty;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            double totalLiters = this.FuelQuantity + liters;
            if (totalLiters < TankCapacity)
            {
                this.FuelQuantity += liters;
            }
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
