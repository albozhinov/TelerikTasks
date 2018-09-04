using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6RemovesNumbersOccurOddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var result = Remove(sequence);

            Console.WriteLine("{" + string.Join(", ", result) + "}");
        }

        public static List<int> Remove(List<int> sequence)
        {
            var result = sequence.Where(n => sequence.Count(x => x == n) % 2 == 0).ToList();
            return result;
        }
    }
}
