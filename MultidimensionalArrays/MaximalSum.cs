using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = ReadMatrix(n[0], n[1]);

            int sumMatrix = 0;
            int maxSum = int.MinValue;
            int[,] maxMatrix = new int[3, 3];


            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {

                    sumMatrix = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sumMatrix>maxSum)
                    {
                        maxSum = sumMatrix;
                        maxMatrix = new int[3,3] 
                        {
                            { matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]},
                            { matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                            { matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]}
                        };
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            PrintMatrix(maxMatrix);
            

        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

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
