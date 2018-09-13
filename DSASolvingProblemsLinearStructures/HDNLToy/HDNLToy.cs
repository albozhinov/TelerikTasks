using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HDNLToy
{
    class HDNLToy
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var tags = new List<string>();

            for (int i = 0; i < N; i++)
            {
                tags.Add(Console.ReadLine());
            }

            var sb = new StringBuilder();

            var stack = new Stack<string>();
            var numStack = new Stack<int>();
            int spaces = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int curr = int.Parse(tags[i].Substring(1));
                int next = int.Parse(tags[i + 1].Substring(1));

                if (curr < next)
                {
                    sb.AppendLine(new string(' ', spaces) + $"<{tags[i]}>");
                    stack.Push(new string(' ', spaces) + $"</{tags[i]}>");
                    numStack.Push(curr);
                    spaces++;
                }
                else if (curr == next)
                {
                    sb.AppendLine(new string(' ', spaces) + $"<{tags[i]}>");
                    sb.AppendLine(new string(' ', spaces) + $"</{tags[i]}>");
                }
                else if (curr > next)
                {
                    sb.AppendLine(new string(' ', spaces) + $"<{tags[i]}>");
                    sb.AppendLine(new string(' ', spaces) + $"</{tags[i]}>");

                    while (stack.Count != 0 && !(next > numStack.Peek()))
                    {
                        sb.AppendLine(stack.Pop());
                        numStack.Pop();
                        spaces--;
                    }
                }
            }

            if (spaces < 0)
            {
                spaces = 0;
            }

            sb.AppendLine(new string(' ', spaces) + $"<{tags[N - 1]}>");
            sb.AppendLine(new string(' ', spaces) + $"</{tags[N - 1]}>");

            while (stack.Count != 0)
            {
                sb.AppendLine(stack.Pop());
            }

            Console.Write(sb.ToString());
        }
    }
}
