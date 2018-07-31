using System;

namespace CheckForPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A
            var n = Console.ReadLine();

            if (n == "2" || n == "3" ||
                n == "4" || n == "5" ||
                n == "6" || n == "7" ||
                n == "8" || n == "9" ||
                n == "10" || n == "J" ||
                n == "Q" || n == "K" ||
                n == "A")
            {
                Console.WriteLine($"yes {n}");
            }
            else
                Console.WriteLine($"no {n}");
        }
    }
}
