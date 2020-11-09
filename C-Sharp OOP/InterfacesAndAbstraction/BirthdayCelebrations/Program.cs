using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<IBirthable> birthables = new List<IBirthable>();

            while (input != "End")
            {
                string[] splited = input.Split();
                
                switch (splited[0])
                {
                    case "Citizen":
                        birthables.Add(new Citizens(splited[3], int.Parse(splited[2]), splited[4], splited[1]));
                        break;
                    case "Pet":
                        birthables.Add(new Pet(splited[1], splited[2]));
                        break;
                }
                
                input = Console.ReadLine();
            }

            string endYear = Console.ReadLine();

            birthables = birthables.Where(i => i.BirthDate.EndsWith(endYear)).ToList();

            foreach (var birthdate in birthables)
            {
                Console.WriteLine(birthdate.BirthDate);
            }
        }

        
    }
}
