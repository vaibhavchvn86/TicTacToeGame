using System;
using TicTacToe;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to tictactoe");
            TicTacToeGame.AssignEmptySpace();
            TicTacToeGame.XorO();
        }
    }
}
