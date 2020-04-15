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
            bool win = false;
            bool won = false;

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

                    //Kör loop ifall check = false. Check variablen finns för att kolla att spelare skriver in en giltig ruta.
                    while (check == false)
                    {                 
                
                        Console.WriteLine("Choose row: (1 - 3)");

                        //Hämtar input från användare. Vilken rad de väljer.
                        row = Console.ReadLine();
                        success = int.TryParse(row, out rowInt);

                        //Ifall de valt en rad som inte finns.
                        while (rowInt != 1 && rowInt != 2 && rowInt != 3)
                        {
                            Console.WriteLine("Please choose a number between 1 and 3.");
                            row = Console.ReadLine();
                            success = int.TryParse(row, out rowInt);
                        }

                        Console.WriteLine("Choose column: (1 - 3)");

                        //Hämtar input från användare. Vilken kolumn de väljer.
                        column = Console.ReadLine();
                        success = int.TryParse(column, out columnInt);

                        //Ifall de valt en kolumn som inte finns.
                        while (columnInt != 1 && columnInt != 2 && columnInt != 3)
                        {
                            Console.WriteLine("Please choose a number between 1 and 3.");
                            column = Console.ReadLine();
                            success = int.TryParse(column, out columnInt);
                        }

                        //Rad och Kolumn läggs ihop till en ruta i en metod och ifall rutan är tom körs följande:
                        if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] == 0)
                        {
                            Console.WriteLine("Player 1 chose tile: " + rowInt + ", " + columnInt);
                            Console.ReadLine();

                            //Sätter rutans value till 1 för att visa att spelare 1 har lagt där.
                            board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] = 1;
                            Console.Clear();

                            //Sätter check till true för att visa att spelaren valt en giltig ruta och kan gå ur loopen.
                            check = true;
                        }

                        //Ifall rutan är upptagen körs följande. Spelaren måste då välja en ny ruta.
                        else if (board[inputRowToBoard(rowInt), inputColumnToBoard(columnInt)] != 0)
                        {
                            Console.WriteLine("This tile is occupied. Please choose another tile.");
                        }

                    }

                    //Spelbrädet ritas ut av denna metod.
                    drawBoard(board);

                    //Winchecker metoden körs. Den kollar ifall någon spelare har vunnit på något sätt.
                    //Metoden innehåller flera andra metoder, en för varje sätt man kan vinna.
                    if (winChecker(won, win, board) == true)
                    {
                        //Sätter isåfall turn = 2, vilket innebär att spelet tar slut. (Turn = 0 är spelare 1) (Turn = 1 är spelare 2)
                        turn = 2;
                    }

                    //Ifall ingen har vunnit:
                    else 
                    {
                        //Sätter "turn" till 1, gör att det blir andra spelarens tur.
                        turn = 1;
                        //Sätter tillbaka check = false, så att nästa spelare inte ska kunna skriva in ogiltig input.
                        check = false;
                    }
                }



                //Spelare 2 får spela eftersom turn = 1;

                //Jag har valt att inte kommentera resten av detta kodblock eftersom det är en kopia av allt ovan.
                //Enda skillnaden är att det nu är Spelare 2 som spelar.

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

                    if(winChecker(won, win, board) == true)
                    {
                        turn = 2;
                    }

                    else
                    {
                        //Sätter tillbaka turn till spelare 1.
                        turn = 0;
                        check = false;
                    }
                    
                }

            }

            //Här ska konsolen skriva ut att en spelare har vunnit och att spelet där med är slut.
            //För någon anledning fungerar detta inte.
            if (turn == 2)
            {
                Console.WriteLine("A Player has won, the game is now over.");
            }

            //En ReadLine som avslutar programmet.
            Console.ReadLine();
        }

        //Metod som kollar ifall en spelare har vunnit.
        static bool winChecker(bool won, bool win, int[,] board)
        {
            if (rowOne(win, board) == true || rowTwo(win, board) == true || rowThree(win, board) == true
                        || columnOne(win, board) == true || columnTwo(win, board) == true || columnThree(win, board) == true
                        || crossOne(win, board) == true || crossTwo(win, board) == true)
            {
                won = true;
            }

            else
            {
                won = false;
            }

            return won;
        }

        //Metod som kollar ifall en spelare har vunnit på första raden.
        static bool rowOne(bool win, int[,] board)
        {
            if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1)
            {
                win = true;
            }
            
            else if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit på andra raden.
        static bool rowTwo(bool win, int[,] board)
        {
            if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
            {
                win = true;
            }

            else if (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit på tredje raden.
        static bool rowThree(bool win, int[,] board)
        {
            if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
            {
                win = true;
            }

            else if (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit på första kolumnen.
        static bool columnOne(bool win, int[,] board)
        {
            if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1)
            {
                win = true;
            }

            else if (board[2, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit på andra kolumnen.
        static bool columnTwo(bool win, int[,] board)
        {
            if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
            {
                win = true;
            }

            else if (board[2, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit på tredje kolumnen.
        static bool columnThree(bool win, int[,] board)
        {
            if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
            {
                win = true;
            }

            else if (board[2, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit från vänsta topp-hörnet till högra botten-hörnet.
        static bool crossOne(bool win, int[,] board)
        {
            if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
            {
                win = true;
            }

            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som kollar ifall en spelare har vunnit från högra topp-hörnet till vänsta botten-hörnet.
        static bool crossTwo(bool win, int[,] board)
        {
            if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                win = true;
            }

            else if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2)
            {
                win = true;
            }

            else
            {
                win = false;
            }

            return win;
        }

        //Metod som ändrar spelarens "Row"-input till (row - 1) för att få rätt index till board[,].
        static int inputRowToBoard(int row)
        {
            row = row - 1;

            return row;
        }

        //Metod som ändrar spelarens "Column"-input till (column - 1) för att få rätt index till board[,].
        static int inputColumnToBoard(int column)
        {
            column = column - 1;

            return column;
        }

        //Metod som ritar ut spelbrädet.
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
