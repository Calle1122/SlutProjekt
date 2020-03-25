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
            int[,] board = new int[15, 15];

            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    board[x, y] = 4;

                    if (x == 0)
                    {
                        board[x, y] = 2;
                    }
                }
            }

            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    Console.Write(board[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
