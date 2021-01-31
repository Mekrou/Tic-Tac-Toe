using System;

namespace Tic_Tac_Toe
{
    enum State
    {
        // integer values = ACSII values of given char
        X = 88,
        O = 79,
        Undecided = 45 // this one is '-', simulating empty.
    }

    class Board
    {
        private int[,] board;
        private int numRows;
        private int numCollums;

        public Board(int numRows, int numCollums)
        {
            this.board = new int[numRows, numCollums];
            this.numRows = numRows;
            this.numCollums = numCollums;
        }

        /// <summary>
        /// Loops through the entire multi-dimensional board array an prints the character associated
        /// with that element value. (X = 88, O = 79, '-' = 45)
        /// </summary>
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

        /// <summary>
        /// Changes a tile on the board depending upon what is passed into it.
        /// </summary>
        /// <param name="state">What state to change the tile to.</param>
        /// <param name="row">What row the tile is in.</param>
        /// <param name="collum">What collum the tile is in.</param>
        public void Update(State state, int row, int collum)
        {
            // subtracting one to account for zero indexing.
            board[row - 1, collum - 1] = (int) state;
        }
    }
}