using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().ToCharArray();
            Array.Reverse(inputLine);
            Console.WriteLine(string.Join("", inputLine));
        }
    }
}
