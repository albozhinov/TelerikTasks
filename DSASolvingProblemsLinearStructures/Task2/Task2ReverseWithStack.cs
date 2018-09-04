using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Task2ReverseWithStack
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var print = new StringBuilder();

            // Fill The Stack
            for (int i = 0; i < N; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));                
            }
            // Reverse and Remove
            for (int i = 0; i < N; i++)
            {
                print.Append(stack.Pop() + " ");
            }
            
            Console.WriteLine("Reverse numbers: {0}", print.ToString());
        }
    }
}
