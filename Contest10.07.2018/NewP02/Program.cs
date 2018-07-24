using System;
using System.Text;

namespace NewP02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            int row = 0;
            int col = 0;

            string direction = "r";


            for (int i = 0; i <= N * N; i++)
            {
                if (direction == "r" && (row))
                {

                }







            }





            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                if (row != N - 1)
                {
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb);
        }
    }
}
