using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Mission4_3_11
{
    /*
    2) The supporting class (with whichever name you choose) will:
    • Receive the “board” array from the driver class
    • Contain a method that prints the board based on the information passed to it
    • Contain a method that receives the game board array as input and returns if there is awinner and who it was
    */
    internal class Support
    {
        public static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] == 1 ? "X|" : board[i, j] == 2 ? "O|" : " |");
                }
                Console.WriteLine();
            }
        }
        public static bool GetWinner(int[,] board, out int whoWon)
        {
            // Check rows, columns, and diagonals for a win
            if (CheckRowWin(board, out whoWon) || CheckColumnWin(board, out whoWon) || CheckDiagonalWin(board, out whoWon))
            {
                return true;
            }
            whoWon = 0;
            return false;
        }
        private static bool CheckRowWin(int[,] board, out int whoWon)
        {
            whoWon = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                {
                    whoWon = board[i, 0];
                    return true;
                }
            }
            return false;
        }
        private static bool CheckColumnWin(int[,] board, out int whoWon)
        {
            whoWon = 0;
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != 0)
                {
                    whoWon = board[0, j];
                    return true;
                }
            }
            return false;
        }
        private static bool CheckDiagonalWin(int[,] board, out int whoWon)
        {
            whoWon = 0;
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
            {
                whoWon = board[0, 0];
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
            {
                whoWon = board[0, 2];
                return true;
            }
            return false;
        }
    }
}