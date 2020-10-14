using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string snakeName = Console.ReadLine();
            char[,] matrix = new char[size[0], size[1]];

            int currentLetter = 0;


            for (int row = 0; row < size[0]; row++)
            {

                if (row % 2 == 0)
                {
                    for (int col = 0; col < size[1]; col++)
                    {

                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;

                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }

                    }
                }
                else
                {
                    for (int col = size[1] - 1; col >= 0; col--)
                    {

                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;

                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }

                    }
                }
                
            }

            PrintMatrix(matrix);
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            string[] rowData = Console.ReadLine().Split();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
