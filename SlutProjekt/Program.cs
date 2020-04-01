using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3];
            int turn;
            string row = "";
            string column = "";
            bool success;
            int rowInt;
            int columnInt;

            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 0;
                }
            }

            Console.WriteLine("      Tic-Tac-Toe");
            Console.WriteLine();
            Console.WriteLine("     1     2     3");
            Console.WriteLine("        │     │");
            Console.WriteLine(" 1   " + board[0, 0] + "  │  " + board[0, 1] + "  │  " + board[0, 2]);
            Console.WriteLine("        │     │");
            Console.WriteLine("   ─────┼─────┼─────");
            Console.WriteLine("        │     │");
            Console.WriteLine(" 2   " + board[1, 0] + "  │  " + board[1, 1] + "  │  " + board[1, 2]);
            Console.WriteLine("        │     │");
            Console.WriteLine("   ─────┼─────┼─────");
            Console.WriteLine("        │     │");
            Console.WriteLine(" 3   " + board[2, 0] + "  │  " + board[2, 1] + "  │  " + board[2, 2]);
            Console.WriteLine("        │     │");
            Console.Read();

            turn = 0;

            while (turn != 2)
            {
                if (turn == 0)
                {
                    Console.WriteLine("Player 1: Place 'X'\n");
                
                    Console.WriteLine("Choose row: (1 - 3)");

                    row = Console.ReadLine();
                    success = int.TryParse(row, out rowInt);

                    while (rowInt != 1 && rowInt != 2 && rowInt != 3)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                        row = Console.ReadLine();
                        success = int.TryParse(row, out rowInt);
                    }

                    Console.WriteLine("Choose column: (1 - 3)");

                    column = Console.ReadLine();
                    success = int.TryParse(column, out columnInt);

                    while (columnInt != 1 && columnInt != 2 && columnInt != 3)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                        column = Console.ReadLine();
                        success = int.TryParse(column, out columnInt);
                    }

                    Console.WriteLine("Player 1 chose tile: " + rowInt + ", " + columnInt);
                    Console.ReadLine();

                    turn = 1;

                }

                if (turn == 1)
                {
                    Console.WriteLine("Player 2: Place 'O'\n");                                 

                    Console.WriteLine("Choose row: (1 - 3)");

                    row = Console.ReadLine();
                    success = int.TryParse(row, out rowInt);

                    while (rowInt != 1 && rowInt != 2 && rowInt != 3)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                        row = Console.ReadLine();
                        success = int.TryParse(row, out rowInt);
                    }

                    Console.WriteLine("Choose column: (1 - 3)");

                    column = Console.ReadLine();
                    success = int.TryParse(column, out columnInt);

                    while (columnInt != 1 && columnInt != 2 && columnInt != 3)
                    {
                        Console.WriteLine("Please choose a number between 1 and 3.");
                        column = Console.ReadLine();
                        success = int.TryParse(column, out columnInt);
                    }

                    Console.WriteLine("Player 2 chose tile: " + rowInt + ", " + columnInt);
                    Console.ReadLine();

                    turn = 0;

                }

            }

        }

        static void inputToBoard(int row, int column)
        {

        }

        static void drawXO()
        {

        }

    }
}
