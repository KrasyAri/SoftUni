using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSrudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsInfo = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfSrudents; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();

                string name = inputInfo[0];
                decimal grade = decimal.Parse(inputInfo[1]);

                if (!studentsInfo.ContainsKey(name))
                {
                    studentsInfo.Add(name, new List<decimal>());
                }
                studentsInfo[name].Add(grade);

            }

            foreach (var item in studentsInfo)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    allGrades.Append($"{item.Value[i]:f2} ");
                }
               
                Console.WriteLine($"{item.Key} -> {allGrades.ToString()}(avg: {item.Value.Average():f2})");
            }
        }
    }
}
