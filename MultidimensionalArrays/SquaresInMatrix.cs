using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = ReadMatrix(n[0], n[1]);
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col] == matrix[row,col+1]
                        && matrix[row, col + 1] == matrix[row+1,col] 
                        && matrix[row + 1, col] == matrix[row+1,col+1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ").ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }
    }
}
