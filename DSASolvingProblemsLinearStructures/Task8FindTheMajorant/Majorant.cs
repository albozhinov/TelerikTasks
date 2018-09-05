using System;
using System.Collections.Generic;
using System.Linq;

namespace Task8FindTheMajorant
{
    class Majorant
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            FindMajorant(sequence);
        }
        public static void FindMajorant(List<int> sequence)
        {
            var result = sequence.GroupBy(e => e)
                                 .Where(e => e.Count() == (sequence.Count / 2) + 1)
                                 .ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No majorant found!");
            }
            else
            {
                result.ForEach(e => Console.WriteLine($"Majorant: {e.Key}"));
            }
        }
    }
}
