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

        /// <summary>
        /// Creates a board filled with defaulted '-' tiles.
        /// </summary>
        public Board()
        {
            this.board = new int[3, 3];
            UpdateBoard(State.Undecided);
        }

        /// <summary>
        /// Prints a Custom Board to display controls
        /// </summary>
        public void PrintControlBoard()
        {
            // This code will run for every row.
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    if (collum == 0) // we want to put spaces so the board is in the middle of the console.
                    {
                        Console.Write("        | {0} |", (char) board[row, collum]);
                        continue;
                    }
                    Console.Write("| {0} |", (char) board[row, collum]);
                }

                // This code only runs for each row.
                switch (row)
                {
                    case 0:
                        Console.WriteLine("        | Q | W | E |");
                        break;
                    case 1:
                        Console.WriteLine("  --->  | A | S | E |"); // Looking at the console output will better explain this.
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
        public void UpdateBoard(PlayerState state, int row, int collum)
        {
            // subtracting one to account for zero indexing.
            board[row - 1, collum - 1] = (int) state;
        }

        /// <summary>
        /// A method to alter every tile on the board.
        /// </summary>
        /// <param name="state">What State to change every tile to.</param>
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

        public void PrintBoard()
        {
            // This code will run for every row.
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int collum = 0; collum < board.GetLength(1); collum++)
                {
                    // This code will print what is needed for each collum.
                    if (collum == 0) // we want to put spaces so the board is in the middle of the console.
                    {
                        Console.Write("               | {0} |", (char)board[row, collum]);
                        continue;
                    }
                    Console.Write("| {0} |", (char)board[row, collum]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}