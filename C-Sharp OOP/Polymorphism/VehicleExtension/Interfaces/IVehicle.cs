using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleExtension.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get;}
        public double FuelConsumptionPerKm  { get; }
        public double TankCapacity { get; }


        public void Drive(double distance);

        public void Refuel(double liters);
    }
}
