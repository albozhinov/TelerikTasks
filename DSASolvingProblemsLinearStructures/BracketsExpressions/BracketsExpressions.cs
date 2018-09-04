using System;
using System.Collections.Generic;

namespace BracketsExpressions
{
    class BracketsExpressions
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var brackets = new Stack<int>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (inputLine[i] == ')')
                {
                    int start = brackets.Pop();
                    int end = i + 1;
                    int lenght = end - start;
                    Console.WriteLine(inputLine.Substring(start, lenght));
                }
            }
        }
    }
}
