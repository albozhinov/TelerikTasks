using System;


namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            input[3] = input[3].TrimEnd(',');
            input[input.Length - 1] = input[input.Length - 1].TrimEnd('!');

            Array.Reverse(input);
            input[3] += ",";
            input[input.Length - 1] += "!";

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
