using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Unit01
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.Write("What is the number of row grids (default is 3)? ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("What is the number of column grids (default is 3)? ");
            int cols = int.Parse(Console.ReadLine());

            List<List<string>> board = CreateGameBoard(rows, cols);
            DisplayGameBoard(board);

        }

        static List<List<string>> CreateGameBoard(int rows, int cols)
        {
            List<List<string>> gameBoard = new List<List<string>>();

            int num = 1;

            for (int i = 0; i < rows; i++)
            {
                List<string> row = new List<string>();

                for (int j = 0; j < cols; j++) 
                {
                    row.Add(num.ToString());
                    num += 1;
                }

                gameBoard.Add(row);
            }

            return gameBoard;
        }

        static void DisplayGameBoard(List<List<string>> gameBoard)
        {
            int rowCount = 0;

            foreach (var row in gameBoard)
            {
                for (int m = 0; m < row.Count; m++)
                {
                    Console.Write($"{row[m]}");

                    if (m != row.Count - 1) Console.Write("|");
                    else Console.WriteLine("");
                }

                if (rowCount != gameBoard.Count - 1) 
                {
                    for (int z = 0; z < row.Count - 1; z++)
                    {
                        Console.Write("-+");
                    }
                    Console.WriteLine("-");
                }
                
                rowCount += 1;
            }
        }
    }
}
