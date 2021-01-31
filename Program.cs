using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = PrintWelcome();

            if (isPlaying == true)
            {
                // print board, start game
            } else
                return;
        }

        private static bool PrintWelcome()
        {
            ConsoleKey consoleInput;
            Board board = new Board();


            Console.WriteLine();
            Console.WriteLine("        <------- Welcome to Tic-Tac-Toe ------->");
            Console.WriteLine("Players will take turns using keys that represents the board.");
            Console.WriteLine();
            board.PrintDefaultBoard();
            Console.WriteLine();
            Console.Write("Press <enter> if you are ready to start the game. <esc> to quit.");
            Console.WriteLine();

            do
            {
                consoleInput = Console.ReadKey().Key;
                if (consoleInput.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    return true;
                }
            } while (!(consoleInput.Equals(ConsoleKey.Escape)));
            
            Console.Clear();
            Console.WriteLine("_Bye!"); // The console will replace first letter with player's key
                                        // so I put an underscore .-.
            return false;
        }
    }
}
