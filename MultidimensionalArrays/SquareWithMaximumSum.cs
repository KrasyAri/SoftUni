using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(n[0], n[1]);

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var newSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxRow,maxCol] + " " + matrix[maxRow, maxCol+1]);
            Console.WriteLine(matrix[maxRow+1, maxCol] + " " + matrix[maxRow+1, maxCol+1]);
            Console.WriteLine(maxSum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }


        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

    }
}
