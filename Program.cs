using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(3, 3);
            board.Update(State.X, 2, 2);
            board.Update(State.X, 1, 3);
            board.Update(State.X, 3, 1);

            board.PrintBoard();

        }
    }
}
