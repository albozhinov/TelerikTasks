using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba11212
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(input[i] - 'a'); 
            }
            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
