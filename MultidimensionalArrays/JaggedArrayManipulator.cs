using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = ReadJagged(rows);

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(x => x * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(x => x / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var splited = command.Split();
                int row = int.Parse(splited[1]);
                int col = int.Parse(splited[2]);
                int value = int.Parse(splited[3]);

                if (splited[0] == "Add")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }

                }
                else if (splited[0] == "Subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            PrintJagged(jagged);
        }

        static double[][] ReadJagged(int rows)
        {
            double[][] jagged = new double[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jagged[row] = new double[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row][col] = rowData[col];
                }
            }

            return jagged;
        }


        static void PrintJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
