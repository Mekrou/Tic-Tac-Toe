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
                PlayerHandler player = new PlayerHandler(); // Handles states of game
                ConsoleKey playerInput;
                Board coreBoard = new Board();
                
                
                bool debounce = false;

                coreBoard.PrintBoard();
                Console.WriteLine("Player one, press either X or O to choose your team.");

                while (debounce == false)
                {
                    playerInput = Console.ReadKey(true).Key;
                    switch (playerInput)
                    {
                        case ConsoleKey.X:
                            debounce = true;
                            player.CurrentPlayerState = PlayerState.X;
                            Console.WriteLine("First move will be X");
                            break;
                        case ConsoleKey.O: 
                            debounce = true;
                            player.CurrentPlayerState = PlayerState.O;
                            Console.WriteLine("First move will be O");
                            break;
                        default:
                            break;
                    }
                }
                player.PlayerMove(coreBoard);
            } 
            else
            {
                return;
            }     
        }

        private static bool PrintWelcome()
        {
            ConsoleKey consoleInput;
            Board board = new Board();

            Console.WriteLine();
            Console.WriteLine("        <------- Welcome to Tic-Tac-Toe ------->");
            Console.WriteLine("Players will take turns using keys that represents the board.");
            Console.WriteLine();
            board.PrintControlBoard();
            Console.WriteLine();
            Console.Write("Press <enter> if you are ready to start the game. <esc> to quit.");
            Console.WriteLine();

            do
            {
                consoleInput = Console.ReadKey(true).Key;
                if (consoleInput.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();
                    return true;
                }
            } while (!(consoleInput.Equals(ConsoleKey.Escape)));
            
            Console.Clear();
            Console.WriteLine("Bye!");
            return false;
        }
    }
}
