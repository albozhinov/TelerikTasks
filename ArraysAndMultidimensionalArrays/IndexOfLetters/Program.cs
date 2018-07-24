using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            for (int i = 0; i < inputLine.Length; i++)
            {
                Console.WriteLine(inputLine[i] - 'a');
            }
        }
    }
}
