using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countOfLetters = CountOfLetters(line);
                int countOfPunct = CountOfPunctoation(line);

                newLines[i] = $"Line {i + 1}: {line} ({countOfLetters})({countOfPunct})";
                
            }

            for (int i = 0; i < newLines.Length; i++)
            {
                Console.WriteLine(newLines[i]);
            }
        }

        static int CountOfLetters(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }

        static int CountOfPunctoation(string line)
        {
            char[] punctoationMarks = { '-', ',', '.', '?', '!', '\'' };

            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (punctoationMarks.Contains(currentSymbol))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
