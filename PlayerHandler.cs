using System;

namespace Tic_Tac_Toe
{
    enum PlayerState
    {
        X = 88,
        O = 79
    }

    class PlayerHandler
    {   
        private PlayerState currentPlayerState;
        private ConsoleKey[] validConsoleKeys = new ConsoleKey[]   {ConsoleKey.Q, ConsoleKey.W, ConsoleKey.E, 
                                                                    ConsoleKey.A, ConsoleKey.S, ConsoleKey.D, 
                                                                    ConsoleKey.Z, ConsoleKey.C, ConsoleKey.X, 
                                                                    ConsoleKey.O, ConsoleKey.Escape, ConsoleKey.Enter};
        private bool gameOver = false;
        public  PlayerState CurrentPlayerState
        {
            get
            {
                return currentPlayerState;
            }
            set
            {
                currentPlayerState = value;
            }
        }


        public void PlayerMove()
        {
            Program program = new Program();
            Board coreBoard = program.CoreBoard;

            Console.WriteLine(currentPlayerState);
            do
            {
                if (currentPlayerState.Equals(PlayerState.X))
                {
                    // Get player's desired tile
                    Console.Clear();
                    coreBoard.PrintControlBoard();
                    Console.WriteLine("Where would you like to place your 'X'?");
                    ConsoleKey playerInput = GetPlayerInput();
                    ResolvePlayerInput(playerInput, PlayerState.X);

                    
                    
                    
                    gameOver = true; // will be replaced by GetWinCondition() method
                    break;
                    // Place 'X' There
                    // Move turn to 'O'
                    // this.currentPlayerState = PlayerState.O;
                } else if (currentPlayerState.Equals(PlayerState.O))
                {
                    Console.Clear();
                    coreBoard.PrintControlBoard();
                    Console.WriteLine("Where would you like to place your 'O'?");
                    ConsoleKey playerInput = GetPlayerInput();
                    ResolvePlayerInput(playerInput, PlayerState.O);

                    gameOver = true;
                    // this.currentPlayerState = PlayerState.X;
                }
            } while (!gameOver);
        }

        public ConsoleKey GetPlayerInput()
        {
            ConsoleKey playerInput;
            bool isValidInput = false;

            do
            {
                playerInput = Console.ReadKey(true).Key;
                foreach (ConsoleKey key in validConsoleKeys)
                {
                    if (playerInput.Equals(key))
                    {
                        isValidInput = true;
                        break;
                    } 
                }
                if (isValidInput == false)
                {
                    Console.WriteLine("Invalid Input! Did you forget the controls?");
                }
            } while (!isValidInput);

            return playerInput;
        }

        public void ResolvePlayerInput(ConsoleKey playerInput, PlayerState sender)
        {
            Program program = new Program();
            Board coreBoard = program.CoreBoard;

            switch (playerInput)
            {
                case ConsoleKey.Q:
                    coreBoard.UpdateBoard(sender, 1,1);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.W:
                    coreBoard.UpdateBoard(sender, 1,2);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.E:
                    coreBoard.UpdateBoard(sender, 1,3);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.A:
                    coreBoard.UpdateBoard(sender, 2,1);
                    coreBoard.PrintBoard();
                    break;   
                case ConsoleKey.S:
                    coreBoard.UpdateBoard(sender, 2,2);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.D:
                    coreBoard.UpdateBoard(sender, 2,3);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.Z:
                    coreBoard.UpdateBoard(sender, 3,1);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.X:
                    coreBoard.UpdateBoard(sender, 3,2);
                    coreBoard.PrintBoard();
                    break;
                case ConsoleKey.C:
                    coreBoard.UpdateBoard(sender, 3,3);
                    coreBoard.PrintBoard();
                    break;             
            }
        }
    }
}