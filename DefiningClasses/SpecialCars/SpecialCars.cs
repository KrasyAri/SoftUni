using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tireInfo = Console.ReadLine();
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (tireInfo != "No more tires")
            {
                string[] splited = tireInfo.Split();
                int year = int.Parse(splited[0] + int.Parse(splited[2]) + int.Parse(splited[4]) + int.Parse(splited[6]));
                double pressure = double.Parse(splited[1]) + double.Parse(splited[3]) + double.Parse(splited[5]) + double.Parse(splited[7]);

                Tire tire = new Tire(year, pressure);
                tires.Add(tire);

                tireInfo = Console.ReadLine();
            }

            string engineInfo = Console.ReadLine();
            while (engineInfo != "Engines done")
            {
                string[] splited = engineInfo.Split();
                int horsepower = int.Parse(splited[0]);
                double cubicCapacity = double.Parse(splited[1]);

                Engine engine = new Engine(horsepower, cubicCapacity);
                engines.Add(engine);

                engineInfo = Console.ReadLine();
            }

            string carInfo = Console.ReadLine();

            while (carInfo != "Show special")
            {
                string[] splited = carInfo.Split();

                Car newCar = new Car(splited[0], splited[1], int.Parse(splited[2]), double.Parse(splited[3]), double.Parse(splited[4]),
                    engines[int.Parse(splited[5])], tires[int.Parse(splited[6])]);
                cars.Add(newCar);   

                carInfo = Console.ReadLine();
            }

            var SpecialCar = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 
                                        && x.Tires.Pressure > 9 && x.Tires.Pressure < 10).ToList();

            foreach (var car in SpecialCar)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
