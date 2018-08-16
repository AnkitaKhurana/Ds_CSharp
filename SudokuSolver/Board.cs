using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Board
    {
        int[,] boardLayout;
        int size;
        public Board()
        {
            size = 9;
            boardLayout = new int[,]{
                      { 3, 0, 6, 5, 0, 8, 4, 0, 0},
                      { 5, 2, 0, 0, 0, 0, 0, 0, 0},
                      { 0, 8, 7, 0, 0, 0, 0, 3, 1},
                      { 0, 0, 3, 0, 1, 0, 0, 8, 0},
                      { 9, 0, 0, 8, 6, 3, 0, 0, 5},
                      { 0, 5, 0, 0, 9, 0, 6, 0, 0},
                      { 1, 3, 0, 0, 0, 0, 2, 5, 0},
                      { 0, 0, 0, 0, 0, 0, 0, 7, 4},
                      { 0, 0, 5, 2, 0, 6, 3, 0, 0}
            }; ;
        }
        public void Display()
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(boardLayout[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public bool CanPlace(int row, int col, int numToPlace)
        {
            //Console.WriteLine("Inside Canplace for("+row+col+")"+numToPlace);
            for (int i = 0; i < boardLayout.GetLength(0); i++)
            {
                if (boardLayout[row, i] == numToPlace)
                    return false;
                if (boardLayout[i, col] == numToPlace)
                    return false;
            }
            //Console.Write("Passes above tests");
            int RootN =(int) Math.Sqrt(boardLayout.GetLength(0));
            int X = row - row % RootN;
            int Y = col - col % RootN;
            for (int i = X; i < X + RootN; i++)
            {
                for (int j = Y; j < Y + RootN; j++)
                {
                    if (boardLayout[i, j] == numToPlace)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        public bool SolveSudoku(int currentRow, int currentCol)
        {
            if (currentRow == boardLayout.GetLength(0))
            {
                return true;
            }
            if (currentCol == boardLayout.GetLength(1))
            {
                return SolveSudoku(currentRow + 1, 0);
            }
            if (boardLayout[currentRow, currentCol] != 0)
            {
                return SolveSudoku(currentRow, currentCol + 1);
            }

            for (int i = 1; i <= boardLayout.GetLength(0); i++)
            {
                bool check = CanPlace(currentRow, currentCol, i);
                //Console.WriteLine(check+"for "+i);
                if (check == true)
                {
                    boardLayout[currentRow, currentCol] = i;
                    if (SolveSudoku(currentRow, currentCol + 1) == true)
                    {
                        return true;
                    }
                    else
                    {
                        boardLayout[currentRow, currentCol] = 0;
                    }
                }
            }
            return false;

        }
    }
}
