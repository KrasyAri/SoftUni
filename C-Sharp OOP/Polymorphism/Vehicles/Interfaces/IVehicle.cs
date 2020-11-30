using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get;}
        public double FuelConsumptionPerKm  { get; }

        
        public void Drive(double distance);

        public void Refuel(double liters);
    }
}
