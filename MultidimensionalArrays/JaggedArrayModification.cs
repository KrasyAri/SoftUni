using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = ReadJagged(rows);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] splited = command.Split();
                string action = splited[0];
                int rowChange = int.Parse(splited[1]);
                int colChange = int.Parse(splited[2]);
                int value = int.Parse(splited[3]);
                
                if (rowChange < 0 || rowChange >= jagged.Length || colChange < 0 || colChange >= jagged.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (action)
                    {
                        case "Add":
                            jagged[rowChange][colChange] += value;
                            break;

                        case "Subtract":
                            jagged[rowChange][colChange] -= value;
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            PrintJagged(jagged);
        }

        static int[][] ReadJagged(int rows)
        {
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jagged[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    jagged[row][col] = rowData[col];
                }
            }

            return jagged;
        }


        static void PrintJagged(int[][] jagged)
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
