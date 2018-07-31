using System;

namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            if (A > B)
                Console.WriteLine($"{B} {A}");
            else
                Console.WriteLine($"{A} {B}");
        }
    }
}
