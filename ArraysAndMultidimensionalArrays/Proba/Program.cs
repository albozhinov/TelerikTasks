using System;
using System.Linq;

namespace Proba
{
    class Program
    {        
        static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ').Select(x => byte.Parse(x)).ToArray();
            var rows = inputLine[0];
            var columns = inputLine[1];
            int[,] matrix = FillTheMatrix(rows, columns);
            byte mostRows = FindRowMostSeq(matrix);
            byte mostColumns = FindColMostSeq(matrix);

            int maxFreqSeq = Math.Max(mostRows, mostColumns);
            Console.WriteLine(maxFreqSeq);
        }

        private static byte FindColMostSeq(int[,] matrix)
        {
            byte mostFreqSeq = 0;
            byte currCounter = 1;
            //int num = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[rows, col] == matrix[rows, col + 1])
                    {
                        currCounter++;
                        if (currCounter > mostFreqSeq)
                        {
                            mostFreqSeq = currCounter;
                            //num = matrix[row, col]; Най - често срещаното число!
                        }
                    }
                    else
                    {
                        currCounter = 1;
                    }
                }

            //Console.WriteLine(num);
            return mostFreqSeq;
        }

        private static byte FindRowMostSeq(int[,] matrix)
        {
            byte mostFreqSeq = 0;
            byte currCounter = 1;
            //int num = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currCounter++;
                        if (currCounter > mostFreqSeq)
                        {
                            mostFreqSeq = currCounter;
                            //num = matrix[row, col]; Най - често срещаното число!
                        }
                    }
                    else
                    {
                        currCounter = 1;
                    }
                }

            //Console.WriteLine(num);
            return mostFreqSeq;
        }

        private static int[,] FillTheMatrix(byte rows, byte columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;

        }
    }
}
