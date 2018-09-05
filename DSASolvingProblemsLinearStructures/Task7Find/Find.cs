using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7Find
{
    class Find
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            FindOccur(sequence);          
        }
        public static void FindOccur(List<int> sequence)
        {            
            sequence.GroupBy(e => e)
                    .OrderBy(e => e.Key)
                    .ToList()
                    .ForEach(e =>
                    Console.WriteLine($"{e.Key} -> {e.Count()} times"));
        }
    }
}
