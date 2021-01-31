using System;

namespace Tic_Tac_Toe
{
    enum State
    {
        X = 88,
        O = 79,
        Undecided = 45
    }

    class Board
    {
        private int[,] board;
        private int numRows;
        private int numCollums;

        
        public Board()
        {
            this.board = new int[3, 3];
        }
        public Board(int numRows, int numCollums)
        {
            this.board = new int[numRows, numCollums];
            this.numRows = numRows;
            this.numCollums = numCollums;
        }

        public void PrintBoard()
        {
            PrintLine();
            // This code will run for every row.
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    Console.Write("| {0} |", (char) board[row, collum]);
                }
                Console.WriteLine();
            }
            PrintLine();
        }

        private void PrintLine()
        {
            Console.WriteLine("---------------");
        }

        public void InitializeBoard()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    board[row, collum] = (int) State.Undecided;
                }
            }
        }
    }
}