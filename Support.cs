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
    * 2) The supporting class (with whichever name you choose) will:
    • Receive the “board” array from the driver class
    • Contain a method that prints the board based on the information passed to it
    • Contain a method that receives the game board array as input and returns if there is awinner and who it was
    */
    internal class Support
    {
        public void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] == 1 ? "X|" : board[i, j] == 2 ? "O|" : " |");
                }
                Console.WriteLine();
            }
        }
    }
}
