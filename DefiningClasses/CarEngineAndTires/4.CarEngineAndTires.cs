using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lambo", "V8", 2009);
            Engine engine = new Engine(650, 1500);
            Tire[] tires = new Tire[]
            {
                new Tire(2008,1200),
                new Tire(2008,1200),
                new Tire(2008,1200),
                new Tire(2008,1200)
            };

            Car toyota = new Car("t", "best", 2020, 50, 10, engine, tires);
           
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(200);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
