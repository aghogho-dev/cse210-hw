using System;
using System.Collections.Generic;
using System.Linq;


// Week 1 - Tic-Tac-Toe
// Aghogho Monorien 

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
            
            int whichPlayer = 1;
            bool isWin = false; 
            bool isDraw = false;

            while (true)
            {
                if (whichPlayer == 1)
                {
                    Console.Write("x's turn to choose a square (1-9): ");
                    
                    int move = int.Parse(Console.ReadLine());

                    bool valid = Player(board, move, rows, cols, "x");

                    isWin = CheckWin(board, "x", rows, cols);

                    if (!isWin) isDraw = CheckDraw(board);
                    
                    if (valid) whichPlayer = 2;
                    else Console.WriteLine("This is an illegal move.");
                }

                else if (whichPlayer == 2)
                {
                    Console.Write("o's turn to choose a square (1-9): ");

                    int move = int.Parse(Console.ReadLine());

                    bool valid = Player(board, move, rows, cols, "o");

                    isWin = CheckWin(board, "o", rows, cols);
                    
                    if (!isWin) isDraw = CheckDraw(board);

                    if (valid) whichPlayer = 1;
                    else Console.WriteLine("This is an illegal move.");
                }
                
                DisplayGameBoard(board);

                if (isWin || isDraw) break;
            }

            if (whichPlayer == 1 && isWin) Console.WriteLine("Player 2 wins.");
            else if (whichPlayer == 2 && isWin) Console.WriteLine("Player 1 wins.");
            else Console.WriteLine("The game ended in a draw.");

            Console.WriteLine("Good game. Thanks for playing.\n");
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
            Console.WriteLine();

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
            Console.WriteLine();
        }

        static bool Player(List<List<string>> gameBoard, int move, int rows, int cols, string playerSign)
        {
            bool validMove = false;
            int countMove = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    countMove += 1;

                    if (countMove == move) 
                    {
                        string checkMove = gameBoard[i][j];
                        int number;
                        validMove = int.TryParse(checkMove, out number);

                        if (validMove) gameBoard[i][j] = playerSign;
                    }
                        
                }
            }
            return validMove;
        }

        static bool CheckWin(List<List<string>> gameBoard, string target, int rows, int cols)
        {
            bool rowMatch = false;

            foreach (List<string> row in gameBoard) 
            {
                bool isRowMatched = row.All(cell => cell == target);

                if (isRowMatched) 
                {
                    rowMatch = isRowMatched;
                    break;
                }
            }

            bool colMatch = false;

            for (int i = 0; i < cols; i++)
            {
                bool isColMatched = gameBoard.All(row => row[i] == target);

                if (isColMatched)
                {
                    colMatch = isColMatched;
                    break;
                }
            }

            bool mainDiag = true, antiDiag = true;
            

            for (int i = 0; i < rows; i++)
            {
                if (gameBoard[i][i] != target) mainDiag = false;

                if (gameBoard[i][rows - 1 - i] != target) antiDiag = false;
            }

            return rowMatch || colMatch || mainDiag || antiDiag;

        }

        static bool CheckDraw(List<List<string>> gameBoard)
        {
            return !gameBoard.SelectMany(row => row).Any(cell => int.TryParse(cell, out _));
        }
    }
}
