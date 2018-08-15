using System;
using System.Collections.Generic;
using System.Linq;

namespace P06DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 50; i++)
            {
                numbers.Add(i);
            }

            numbers.Where(x => x % 3 == 0 || x % 7 == 0).ToList().ForEach(x => { Console.WriteLine(x); });             
        }
    }
}
