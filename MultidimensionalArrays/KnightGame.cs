using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            FillMatrix(board);

            int countReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = board[row, col];
                        int countAttacks = 0;

                        if (currentSymbol == 'K')
                        {
                            countAttacks = GetAttacks(board, row, col, countAttacks);

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    board[rowKiller, colKiller] = '0';
                    countReplaced++;
                }

                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }

        }

        private static int GetAttacks(char[,] board, int row, int col, int countAttacks)
        {
            if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
            {

                countAttacks++;

            }

            if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
            {

                countAttacks++;

            }

            return countAttacks;
        }

        static char[,] FillMatrix(char[,] numbers)
        {
            
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = currentRow[col];
                }
            }

            return numbers;
        }

        static void PrintMatrix(char[,] matrix)
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

        private static bool IsInside(char[,] board, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < board.GetLength(0)
                && targetCol >= 0 && targetCol < board.GetLength(1);
        }
    }
}
