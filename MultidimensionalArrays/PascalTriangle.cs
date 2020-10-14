using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];
            int cols = 1;

            for (int row = 0; row < pascal.Length; row++)
            {
                pascal[row] = new long[cols];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                if (row >1)
                {
                    for (int col = 1; col < pascal[row].Length-1; col++)
                    {
                        long[] prevRow = pascal[row - 1];
                        long firstNum = prevRow[col];
                        long secondNum = prevRow[col - 1];

                        pascal[row][col] = firstNum + secondNum;
                    }
                }
                cols++;
            }

            PrintJagged(pascal);


        }


        static long[][] ReadJagged(int rows)
        {
            long[][] jagged = new long[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jagged[row] = new long[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row][col] = rowData[col];
                }
            }

            return jagged;
        }


        static void PrintJagged(long[][] jagged)
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
