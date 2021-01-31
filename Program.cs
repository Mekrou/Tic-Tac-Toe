using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            // PlayerHandler players = new PlayerHandler();

            // board.Update(State.X, 2, 2);
            // board.Update(State.X, 1, 3);
            // board.Update(State.X, 3, 1);

            // board.PrintBoard();

        }

        private static void PrintWelcome()
        {
            Board board = new Board();
            Console.WriteLine();
            Console.WriteLine("        <------- Welcome to Tic-Tac-Toe ------->");
            Console.WriteLine("Players will take turns using keys that represents the board.");
            Console.WriteLine();
            board.PrintDefaultBoard();
            Console.WriteLine();
            Console.Write("Press <enter> if you are ready to start the game.");
        }
    }
}
