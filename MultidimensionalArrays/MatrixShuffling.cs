using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];
            string[,] matrix = ReadMatrix(rows, cols);

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (Validation(command,rows,cols))
                {
                    string[] splitedCommand = command.Split();
                    string action = splitedCommand[0];
                    int rowIndexFirst = int.Parse(splitedCommand[1]);
                    int colIndexFirst = int.Parse(splitedCommand[2]);
                    int rowIndexSec = int.Parse(splitedCommand[3]);
                    int colIndexSec = int.Parse(splitedCommand[4]);

                    string firstElement = matrix[rowIndexFirst, colIndexFirst];
                    string secongElement = matrix[rowIndexSec, colIndexSec];

                    matrix[rowIndexSec, colIndexSec] = firstElement;
                    matrix[rowIndexFirst, colIndexFirst] = secongElement;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
               

                command = Console.ReadLine();
            }

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

        static void PrintMatrix(string[,] matrix)
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

        private static bool Validation(string command, int rows, int cols)
        {
           
            string[] splitedCommand = command.Split();

            if (splitedCommand.Length == 5 && splitedCommand[0] == "swap" &&
                int.Parse(splitedCommand[1]) <= rows && int.Parse(splitedCommand[2]) <= cols &&
                int.Parse(splitedCommand[3]) <= rows && int.Parse(splitedCommand[4]) <= cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
