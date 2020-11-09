using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IID> ids = new List<IID>();

            while (input != "End")
            {
                string[] splited = input.Split();

                if (splited.Length == 2)
                {
                    ids.Add(new Robots(splited[1],splited[0]));
                }
                else
                {
                    ids.Add(new Citizens(splited[2], splited[0], int.Parse(splited[1])));
                }

                input = Console.ReadLine();
            }

            string lastDigits = Console.ReadLine();

            ids = ids.Where(i => i.Id.EndsWith(lastDigits)).ToList();

            foreach (var id in ids)
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}
