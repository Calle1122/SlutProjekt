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
            //Alla variabler skapas.
            int[,] board = new int[3, 3];
            string[] xoBoard;
            xoBoard = new string[3]{" ", "X", "O"};
            int turn;
            string row = "";
            string column = "";
            bool success;
            int rowInt;
            int columnInt;
            bool check = false;

            //Sätter alla positioner i spelbrädet till "0", vilket innebär att ingen har spelat sin bricka på dem.
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 0;
                }
            }

            //Kallar på metoden som ritar spelbrädet.
            drawBoard(board);

            //Sätter "turn" till Player 1. Innebär att spelare 1 börjar.
            turn = 0;

            //Startar loopen som låter spelarna turas om att lägga ut sina pjäser.
            while (turn != 2)
            {
                //Spelare 1 får spela ifall turn = 0;
                if (turn == 0)
                {
                    Console.WriteLine("Player 1: Place 'X'\n");

                    while (check == false)
                    {                 
                
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

                        if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] == 0)
                        {
                            Console.WriteLine("Player 1 chose tile: " + rowInt + ", " + columnInt);
                            Console.ReadLine();

                            board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] = 1;
                            Console.Clear();

                            check = true;
                        }

                        else if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] != 0)
                        {
                            Console.WriteLine("This tile is occupied. Please choose another tile.");
                        }

                    }

                    drawBoard(board);

                    //Sätter "turn" till 1, gör att det blir andra spelarens tur.
                    turn = 1;
                    check = false;

                }



                //Spelare 2 får spela eftersom turn = 1;
                if (turn == 1)
                {
                    Console.WriteLine("Player 2: Place 'O'\n");                                 

                    while (check == false) 
                    {

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

                        if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] == 0)
                        {
                            Console.WriteLine("Player 2 chose tile: " + rowInt + ", " + columnInt);
                            Console.ReadLine();

                            board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] = 2;
                            Console.Clear();

                            check = true;
                        }

                        else if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] != 0)
                        {
                            Console.WriteLine("This tile is occupied. Please choose another tile.");
                        }

                    }

                    drawBoard(board);                   

                    //Sätter tillbaka turn till spelare 1.
                    turn = 0;
                    check = false;

                }

            }

        }
        static int inputRowToBoard(int row)
        {
            row = row - 1;

            return row;
        }

        static int inputColumnToBoard(int column)
        {
            column = column - 1;

            return column;
        }

        static void drawBoard(int[,] board)
        {
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
        }

    }
}
