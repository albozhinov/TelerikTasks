using System;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int row = 0;
            int col = 0;


            int counter = 1;
            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < N; k++)
                    {
                        matrix[row, col] = counter;
                        col++;
                        counter++;
                    }                    
                }
                else if (i == 1)
                {
                    col--;
                    for (int c = 0; c < N - 1; c++)
                    {
                        row++;
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else if (i == 2)
                {
                    
                    for (int c = 0; c < N - 1; c++)
                    {
                        
                        matrix[row, col - 1 - c] = counter;
                        counter++;
                    }
                    col = col - 1 - N - 1;
                    row--;
                }
                else if (i >= 2)
                {
                    for (int c = N - 2; c >= 1; c--)
                    {
                        matrix[row, col] = counter;
                        row = c;
                        counter++;
                    }
                }
                

            }


        }
    }
}
