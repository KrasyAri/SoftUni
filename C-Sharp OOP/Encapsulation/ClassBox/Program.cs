using System;

namespace ClassBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(lenght, width, height);

                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralSurfaceArea());
                Console.WriteLine(box.Volume());
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
