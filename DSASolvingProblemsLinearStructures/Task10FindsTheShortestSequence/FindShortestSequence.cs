using System;
using System.Collections.Generic;
using System.Text;

namespace Task10FindsTheShortestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            var numbers = new Stack<int>();

            while (N != M)
            {
                numbers.Push(M);

                if (M / 2 >= N)
                {
                    if (M % 2 == 0)
                    {
                        M /= 2;
                    }
                    else
                    {
                        M--;
                    }
                }
                else
                {
                    if (M - 2 >= N)
                    {
                        M -= 2;
                    }
                    else
                    {
                        M--;
                    }
                }
            }
            numbers.Push(N);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
