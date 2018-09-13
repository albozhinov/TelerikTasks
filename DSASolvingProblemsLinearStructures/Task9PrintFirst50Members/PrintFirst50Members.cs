using System;
using System.Collections.Generic;
using System.Text;

namespace Task9PrintFirst50Members
{
    class PrintFirst50Members
    {
        static void Main(string[] args)
        {
            int N = 2;

            var members = new Queue<int>();

            members.Enqueue(N);

            var sb = new StringBuilder();

            
            for (int i = 0; i < 50; i++)
            {
                var S1 = members.Dequeue();

                members.Enqueue(S1 + 1);
                members.Enqueue((2 * S1) + 1);
                members.Enqueue(S1 + 2);

                sb.Append($"{S1}, ");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
