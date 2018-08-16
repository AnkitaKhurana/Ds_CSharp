using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            b.Display();
            b.SolveSudoku(0,0);
            Console.WriteLine("After Solving");
            b.Display();
            Console.ReadKey();
        }
    }
}
