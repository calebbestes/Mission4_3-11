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

        // Create 3X3 board
        int[,] gameBoard = new int[3,3];

        // Initialize Variables
        int playerID = 0;
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

            // Get input until it is valid (integer, in range, move not taken)
            do
            {
                // Ask for player to make move
                Console.WriteLine($"Make your move Player {playerID}");

                // Get row number
                Console.Write($"Enter row number (1-{gameBoard.GetLength(0)}):");
                if (int.TryParse(Console.ReadLine(), out int rowInput) && rowInput >= 1 && rowInput <= 3)
                {
                    // Get column number
                    Console.Write($"Enter column number (1-{gameBoard.GetLength(1)}):");
                    if (int.TryParse(Console.ReadLine(), out int colInput) && colInput >= 1 && colInput <= 3)
                    {
                        // Change range from user input 1-3 to array indicies 0-2
                        rowInput--;
                        colInput--;

                        // If move spot is taken, try again
                        if (gameBoard[rowInput, colInput] != 0)
                        {
                            invalidInput = true;
                            Console.WriteLine("Sorry! That move has been taken. Please enter a valid move.");
                        }
                        // If no errors, put move on board
                        else
                        {
                            invalidInput = false;
                            gameBoard[rowInput, colInput] = playerID;
                        }
                    }
                    else
                    {
                        invalidInput = true;
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }
                else
                {
                    invalidInput = true;
                    Console.WriteLine("Please enter a valid integer.");
                }

            // Exit input loop if input is valid
            } while (invalidInput);

            // Print board
            Support s = new Support();
            s.PrintBoard(gameBoard);

            // Get winner, if any
            //s.GetWinner(gameBoard, out bool win, out int whoWon);
        }   
    }
}
