using System;

namespace Tic_Tac_Toe
{
    class Board
    {
        private int[,] board = new int[3, 3];
        public void PrintBoard()
        {
            PrintLine();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.WriteLine("| {0} | {1} | {2} |", (char) board[row, 0], (char) board[row, 1], (char) board[row, 2]);
            }
            PrintLine();
        }

        public void SetBoard(int newValue, int row, int collum)
        {
            if (newValue == 0)
            {

            } else if (newValue == 1)
            {
                
            }
            // accounting for zero-indexing
            board[row - 1, collum - 1] = newValue;
        }

        private void PrintLine()
        {
            Console.WriteLine("-------------");
        }
    }
}