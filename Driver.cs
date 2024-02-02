using Mission4_3_11;
using System;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{    
    private static void Main(string[] args)
    {
        // Welcome User
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create array to hold 9 possible choices on game board
        int[] gameBoard = new int[9];

        // Initialize Variables
        int playerID = 0;
        int playerMove = 0;
        bool invalidInput = false;


        // Take turns for as many spots on game board
        for (int i = 0; i < gameBoard.Length; i++)
        {
            // Even Numbered Turns
            if (i % 2 == 0)
            {
                playerID = 1;
            }
            // Odd Numbered Turns
            else
            {
                playerID = 2;
            }
            
            // THIS IS FOR TESTING
            // Console.WriteLine(string.Join(", ", gameBoard));

            // Get input until it is valid (integer, in range, move not taken)
            do
            {
                // Ask player for move
                Console.WriteLine("Make your move Player " + playerID + ". Enter a number 1-9: ");

                // Get move, execute the following if input is an integer
                if (int.TryParse(Console.ReadLine(), out playerMove))
                {
                    // Change range from user input 1-9 to array indicies 0-8
                    playerMove--;

                    // If move is out of range, try again
                    if (playerMove < 1 || playerMove > 9)
                    {
                        invalidInput = true;
                        Console.WriteLine("Please enter a number 1-9.");
                    }
                    // If move spot is taken, try again
                    else if (gameBoard[playerMove] != 0)
                    {
                        invalidInput = true;
                        Console.WriteLine("Sorry! That move has been taken. Please enter a valid move.");
                    }
                    // If no errors, input is valid
                    else
                    {
                        invalidInput = false;
                    }
                }
                // If input is not an integer, try again
                else
                {
                    invalidInput = true;
                    Console.WriteLine("Please enter a valid integer.");
                }

            // Exit input loop if input is valid
            } while (invalidInput);

            // Put player move on board if valid
            gameBoard[playerMove] = playerID;

            // Print board
            //Support s = new Support();
            //s.PrintBoard(gameBoard);

            // Get winner, if any
            //s.GetWinner(gameBoard, out bool win, out int whoWon);
        }   
    }
}
