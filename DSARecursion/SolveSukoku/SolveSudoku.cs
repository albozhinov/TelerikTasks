using System;
using System.Text;

namespace SolveSukoku
{
    class SolveSudoku
    {
        private static int[,] sudokuMatrix = new int[9, 9];

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                FillTheMatix(Console.ReadLine(), i);
            }

            Solve(0, 0);
        }

        public static void Solve(int row, int col)
        {
            // Bottom
            if (row == 9 && col == 0)
            {
                PrintTheMatrix();
                Environment.Exit(0);
            }
            else if (sudokuMatrix[row, col] == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    // Check if currRow and currCol contains currNum :)
                    if (CheckCurrRow(row, i) || CheckCurrCol(col, i) || CheckSubSquare(row, col, i))
                    {
                        continue;
                    }

                    sudokuMatrix[row, col] = i;
                    Solve(NextRow(row, col), NextCol(col));
                    sudokuMatrix[row, col] = 0;
                }
            }
            else
            {
                Solve(NextRow(row, col), NextCol(col));
            }
        }

        public static int NextCol(int col)
        {
            col++;
            if (col > 8)
            {
                return 0;
            }

            return col;
        }

        public static int NextRow(int row, int col)
        {
            col++;
            if (col > 8)
            {
                return row + 1;
            }

            return row;
        }

        public static bool CheckCurrRow(int row, int number)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudokuMatrix[row, j] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckCurrCol(int col, int number)
        {
            for (int k = 0; k < 9; k++)
            {
                if (sudokuMatrix[k, col] == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CheckSubSquare(int row, int col, int num)
        {
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int k = startCol; k < startCol + 3; k++)
                {
                    if (sudokuMatrix[i, k] == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void FillTheMatix(string input, int rowIndex)
        {
            for (int row = rowIndex; row < rowIndex + 1; row++)
            {
                for (int col = 0; col < sudokuMatrix.GetLength(1); col++)
                {
                    bool curNum = int.TryParse(input[col].ToString(), out int parseNum);
                    if (curNum)
                    {
                        sudokuMatrix[row, col] = parseNum;
                    }
                }
            }
        }

        public static void PrintTheMatrix()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < sudokuMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < sudokuMatrix.GetLength(1); col++)
                {
                    sb.AppendFormat($"{sudokuMatrix[row, col]}");
                }
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
