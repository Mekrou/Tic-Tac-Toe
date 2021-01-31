using System;

namespace Tic_Tac_Toe
{
    enum PlayerState
    {
        X,
        Y,
        Unassigned
    }
    enum PlayerMove
    {
        Q = 0, W = 1, E = 3,
        A = 4, S = 5, D = 6,
        Z = 7, X = 8, C = 9, 

        T = 10, Y = 11, U = 12,
        G = 13, H = 14, J = 15,
        B = 16, N = 17, M = 19
    }

    class PlayerHandler
    {
        private PlayerState currentPlayerState;

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
            int playerInput = Convert.ToInt32(Console.ReadLine());
        }

        public void AssignState()
        {
            Console.WriteLine();
        }
    }
}