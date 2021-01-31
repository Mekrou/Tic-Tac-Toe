using System;

namespace Tic_Tac_Toe
{
    enum PlayerState
    {
        X,
        O
    }

    enum PlayerKey
    {
        Q = 1, W = 2, E = 3,
        A = 4, S = 5, D = 6,
        Z = 7, X = 8, C = 9
    }

    class PlayerHandler
    {   
        private PlayerState currentPlayerState;
        private PlayerKey currentPlayerKey;

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

        public PlayerKey CurrentPlayerKey
        {
            get
            {
                return currentPlayerKey;
            }
            set
            {
                currentPlayerKey = value;
            }
        }

        public void PlayerMove()
        {
            Console.WriteLine("Entered PlayerMove()");
        }
    }
}