using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                string power = engineInfo[1];
                string displacement = "n/a";
                string efficiancy = "n/a";

                if (engineInfo.Length == 4)
                {
                    displacement = engineInfo[2];
                    efficiancy = engineInfo[3];
                }
                
                else if (engineInfo.Length == 3)
                {
                    int possibleDisplacement;
                    bool isDisplacement = int.TryParse(engineInfo[2], out possibleDisplacement);
                    //char[] info = engineInfo[2].ToCharArray();
                    if (isDisplacement)
                        //(info[0] >= 65 && info[0] <= 90)
                    {
                         displacement = engineInfo[2];
                        
                    }
                    else
                    {
                        efficiancy = engineInfo[2];
                        
                    }
                }


                Engine engine = new Engine(model, power, displacement, efficiancy);

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int j = 0; j < m; j++)
            {
                //"{model} {engine} {weight} {color}" 
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string currentEngine = carInfo[1];
                string weight = "n/a";
                string colour = "n/a";

                if (carInfo.Length == 4)
                {
                    weight = carInfo[2];
                    colour = carInfo[3];
                }
                
                else if (carInfo.Length == 3)
                {
                    int possibleWeight;
                    bool isWeight = int.TryParse(carInfo[2], out possibleWeight);
                    //char[] info = carInfo[2].ToCharArray();
                    if (isWeight)
                    {
                        weight = carInfo[2];
                    }
                    else
                    {
                        colour = carInfo[2];
                    }
                }

                foreach (var item in engines)
                {
                    if (item.Model == currentEngine)
                    {
                        Car car = new Car(model, item, weight, colour);
                        cars.Add(car);
                    }
                }
            }

            foreach (var car in cars)
            {
                    Console.WriteLine($"{car.Model}:");
                    Console.WriteLine($"  {car.Engine.Model}:");
                    Console.WriteLine($"    Power: {car.Engine.Power}");
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                    Console.WriteLine($"  Weight: {car.Weight}");
                    Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
