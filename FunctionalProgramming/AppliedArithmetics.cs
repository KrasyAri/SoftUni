using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x *2;
            Func<int, int> subtractFunc = x => x - 1;
            Action<List<int>> printFunc = x => Console.WriteLine(string.Join(" ", x));
            
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!= "end")
            {

                switch (command)
                {
                    case "add":
                        nums = nums.Select(addFunc).ToList();
                        break;

                    case "multiply":
                        nums = nums.Select(multiplyFunc).ToList();
                        break;
                    case "subtract":
                        nums = nums.Select(subtractFunc).ToList();
                        break;
                    case "print":
                        printFunc(nums);
                        break;
                }


                command = Console.ReadLine();
            }
        }
    }
}
