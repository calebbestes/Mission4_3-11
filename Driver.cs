using System;
using System.Reflection.Metadata;

internal class Program
{
    private static int playerID = 0;
    private static string playerShape = "";
    private static int playerMove = 0;

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Creates an array to hold 9 possible choices on gameboard
        int[] gameBoard = new int[9];

        for (int i = 0; i < gameBoard.Length; i++)
        {
            if (i % 2 == 0)
            {
                playerID = 1;
                playerShape = "X";
            }
            else
            {
                playerID = 2;
                playerShape = "O";
                
            }
            Console.WriteLine("Make your move Player " + playerID + ". Choose a number 1-9: ");
            int playerMove = int.Parse(Console.ReadLine());
            gameBoard[playerMove -  1] = playerShape;
        }
    }
}
