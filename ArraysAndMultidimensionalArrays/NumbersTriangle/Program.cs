using System;
using System.Text;

namespace NumbersTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= size; i++)
            {
                for (int k = 1; k <= i; k++)                
                sb.Append(k + " ");

                sb.AppendLine();               
            }

            for (int i = 0; i < size; i++)
            {
                for (int k = 1; k < size - i; k++)
                {
                    sb.Append(k + " ");
                }
                if (i == size - 1)
                {
                    continue;
                }
                sb.AppendLine();
            }
            Console.Write(sb);
        }
    }
}
