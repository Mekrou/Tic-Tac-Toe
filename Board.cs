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
            UpdateBoard(State.Undecided);
        }

        /// <summary>
        /// Prints a Custom Board to display controls
        /// </summary>
        public void PrintDefaultBoard()
        {
            // This code will run for every row.
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    if (collum == 0)
                    {
                        Console.Write("        | {0} |", (char) board[row, collum]);
                        continue;
                    }
                    Console.Write("| {0} |", (char) board[row, collum]);
                }

                switch (row)
                {
                    case 0:
                        Console.WriteLine("        | Q | W | E |");
                        break;
                    case 1:
                        Console.WriteLine("  --->  | A | S | E |");
                        break;
                    case 2:
                        Console.WriteLine("        | Z | X | C |");
                        break;
                }
            }
        }


        /// <summary>
        /// Changes a tile on the board depending upon what is passed into it.
        /// </summary>
        /// <param name="state">What state to change the tile to.</param>
        /// <param name="row">What row the tile is in.</param>
        /// <param name="collum">What collum the tile is in.</param>
        public void UpdateBoard(State state, int row, int collum)
        {
            // subtracting one to account for zero indexing.
            board[row - 1, collum - 1] = (int) state;
        }

        public void UpdateBoard(State state)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    board[row, collum] = (int) state;
                }
            }
        }
    }
}