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
                        Console.WriteLine("  --->  | A | S | D |"); // Looking at the console output will better explain this.
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

        // public int ResolveWinCondition()
        // {
        //     int counter = 1;
        //     int[] results = new int[8];

        //     while (counter <= 8) // we have a total of 8 win conditions.
        //     {
        //         for (int i = 0; i < results.Length; i++)
        //         {
        //             results[i] = evaluateCondition(i);
        //         }
        //         counter++;
        //     }
        //     int[] firstRow = getRow(1);
        //     int[] secondRow = getRow(2);
        //     int[] thirdRow = getRow(3);


        //     return 0; // No one won, yet.
        // }

        public int[] getRow(int row)
        {
            int[] valuesInRow = new int[3];

            if (row > 0 && row <= 3) // There are only 3 rows in the board, is passed row less than 3?
            {
                for (int _row = 0; _row < board.GetLength(0); _row++)
                {
                    for (int collum = 0; collum < board.GetLength(1); collum++)
                    {
                        valuesInRow[collum] = board[row - 1, collum]; // row - 1 accounts for zero indexing (user can get row 1,2, or 3)
                    }
                }
                
                return valuesInRow;
            } else
                return null;
        }

        public int[] getCollum(int collum)
        {
            int[] valuesInRow = new int[3];

            for (int i = 0; i < valuesInRow.Length; i++)
            {
                valuesInRow[i] = board[i, collum - 1];
            }
            
            return valuesInRow;
        }

        // public int evaluateCondition(int i)
        // {
        //     int[] valuesOfBoard = new int[3];
        //     int result = 0;
            
        //     switch (i)
        //     {
        //         // Evaluate first row
        //         case 0:
        //             valuesOfBoard = getRow(1);
        //             result = evaluate(valuesOfBoard);
        //             return result;

        //         // Evaluate second row
        //         case 1:
        //             valuesOfBoard = getRow(2);
        //             result = evaluate(valuesOfBoard);
        //             return result;
        //         // Evaluate third row
        //         case 2:
        //             valuesOfBoard = getRow(3);
        //             result = evaluate(valuesOfBoard);
        //             return result;
        //         // Evaluate first collum
        //         case 3:

        //         // Evaluate second collum
        //         case 4:
        //         // Evaluate third collum
        //         case 5:
        //         // Evaluate top-bottom diagonal
        //         case 6:
        //         // Evaluate bottom-top diagonal
        //         case 7:
        //     }
        // }

        public int evaluate(int[] valuesOfBoard)
        {
            int sum = 0;
            foreach (int element in valuesOfBoard)
            {
                sum += element;
            }

            switch (sum)
            {
                case 264:
                    return 1; // X won
                case 237:
                    return 2; // O won
                default:
                    return 0; // No one won
            }
        }
    }
}