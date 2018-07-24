using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P03.JoroTheNaughty
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = inputLine[0];
            int cols = inputLine[1];
            int jumpsCount = inputLine[2];

            var firstPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] matrix = FillTheMatrix(rows, cols);
            bool[,] visited = new bool[rows, cols];

            int startROw = firstPosition[0];
            int startCol = firstPosition[1];

            visited[startROw, startCol] = true;

            IsVisited(jumpsCount, visited);
            BigInteger sum = 0;


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (visited[r,c])
                    {
                        sum += matrix[r, c];
                    }
                }
            }
            Console.WriteLine($"escaped {sum}");
        }

        private static void IsVisited(int jumpsCount, bool[,] visited)
        {
            int targetRow = 0;
            int targetCol = 0;
            List<int> moveRows = new List<int>();
            List<int> moveCols = new List<int>();

            int counter = 1;
            var jumpsCordinate = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            targetRow = jumpsCordinate[0];
            targetCol = jumpsCordinate[1];
            moveRows.Add(jumpsCordinate[0]);
            moveCols.Add(jumpsCordinate[1]);

            for (int i = 1; i <= jumpsCount; i++)
            {
                if (visited[targetRow, targetCol])
                {
                    Console.WriteLine($"caught {counter}"); // Виж дали няма да е необходимо да добавиш counter++ тук.
                    Environment.Exit(0);
                }
                if (!visited[targetRow, targetCol])
                {
                    visited[targetRow, targetCol] = true;
                    counter++;
                }
                if (i < jumpsCount)
                {
                    jumpsCordinate = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    targetRow += jumpsCordinate[0];
                    targetCol += jumpsCordinate[1];
                    moveRows.Add(jumpsCordinate[0]);
                    moveCols.Add(jumpsCordinate[1]);
                }
            }
            int currNum = 0;
            targetRow += moveRows[currNum];
            targetCol += moveCols[currNum];
            

            while (true)
            {
                if (targetRow >= visited.GetLength(0) || targetRow < 0 || targetCol >= visited.GetLength(1) || targetCol < 0)
                {
                    return;
                }
                if (visited[targetRow, targetCol])
                {                    
                    Console.WriteLine($"caught {counter}");
                    Environment.Exit(0);
                }
                if (!visited[targetRow, targetCol])
                {
                    visited[targetRow, targetCol] = true;
                    counter++;
                }
                currNum++;

                if (currNum == moveRows.Count)
                {
                    currNum = 0;
                }
                targetRow += moveRows[currNum];
                targetCol += moveCols[currNum];
            }                
        }

        private static int[,] FillTheMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int num = 1;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = num++;
                }
            }            
            return matrix;
        }
    }
}
