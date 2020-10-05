using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._10___Streams_Files_and_Directories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;
                
                while (line != null)
                {

                    
                    if (count % 2 != 0)
                    {
                        Regex patern = new Regex("[-,.?!]");
                        line = patern.Replace(line,"@");
                        var array = line.Split().ToArray().Reverse();
                        Console.WriteLine(string.Join(" ",array));
                        
                    }
                    count++;
                    line = reader.ReadLine();
                }
               


            }
        }
    }
}
