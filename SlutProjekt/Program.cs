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

            Console.WriteLine("   Tic-Tac-Toe");
            Console.WriteLine();
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.WriteLine("─────┼─────┼─────");
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.WriteLine("─────┼─────┼─────");
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.WriteLine("     │     │");
            Console.Read();

        }
    }
}
