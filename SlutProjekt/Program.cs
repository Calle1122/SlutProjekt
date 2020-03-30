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
            int turn = 0;
            string row = "";
            string column = "";

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

            while (turn != 2)
            {
                while (turn == 0)
                {
                    Console.WriteLine("Player 1: Place 'X'");
                    Console.WriteLine();
                    Console.WriteLine("Choose row: (1 - 3)");

                    row = Console.ReadLine();
                    int rowInt;
                    bool success = int.TryParse(row, out rowInt);

                    Console.WriteLine("Choose column: (1 - 3)");

                    column = Console.ReadLine();
                    int columnInt;
                    success = int.TryParse(column, out columnInt);

                    turn = 1;
                }

                while (turn == 1)
                {
                    Console.WriteLine("Player 2: Place 'O'");
                    Console.WriteLine();
                    Console.WriteLine("");

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
