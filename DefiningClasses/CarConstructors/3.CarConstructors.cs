using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lambo", "V8", 2009);

           
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(200);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
