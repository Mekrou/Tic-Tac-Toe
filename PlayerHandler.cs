using System;

namespace Tic_Tac_Toe
{
    enum PlayerState
    {
        X = 1,
        O = 2
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
            Board board = new Board();
            Console.WriteLine(currentPlayerState);
            do
            {
                if (currentPlayerState.Equals(PlayerState.X))
                {
                    // Get player's desired tile
                    Console.Clear();
                    board.PrintControlBoard();
                    Console.WriteLine("Where would you like to place your 'X'?");
                    ConsoleKey playerInput = GetPlayerInput();
                    
                    
                    gameOver = true;
                    break;
                    // Place 'X' There
                    // Move turn to 'O'
                    // this.currentPlayerState = PlayerState.O;
                } else if (currentPlayerState.Equals(PlayerState.O))
                {
                    Console.WriteLine("Where would you like to place your 'Y'?");
                    this.currentPlayerState = PlayerState.X;
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
    }
}