using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public char[] arr;
        /// <summary>
        /// UC1 Assigns the empty space.
        /// </summary>
        public static void AssignEmptySpace()
        {
            char[] arr = new char[10];

            for (int i = 1; i < 10; i++)
                arr[i] = ' ';
        }
        /// <summary>
        ///UC2 Choose X or O.
        /// </summary>
        public static void XorO()
        {
            string player, C;
            Console.WriteLine("Choose X or O to for Playing the Game ");
            player = Convert.ToString(Console.ReadLine()).ToUpper();
            if (player == "X")
            {
                C = "O";
                Console.WriteLine("Computer : "+C);
            }
            else if(player == "O")
            {
                C = "X";
                Console.WriteLine("Computer : "+ C);
            }
            else
                Console.WriteLine("Invalid input Choose X or O only");
        }
        public static void showBoard()
        {
            AssignEmptySpace();
           
            Console.WriteLine("Creating a TicTacToe Game Board");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {1}  |  {2}  |  {3}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {4}  |  {5}  |  {6}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {7}  |  {8}  |  {9}");
        }
    }
}
