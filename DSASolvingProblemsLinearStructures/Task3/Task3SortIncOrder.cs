using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Task3SortIncOrder
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var sequence = new List<int>();

            while (true)
            {
                if (line == "")
                {
                    break;
                }
                var num = int.Parse(line);
                sequence.Add(num);
                line = Console.ReadLine();
            }
            Console.WriteLine("Sorted in an increasing order: {0}", string.Join(", ", sequence.OrderBy(x => x)));
        }
    }
}
