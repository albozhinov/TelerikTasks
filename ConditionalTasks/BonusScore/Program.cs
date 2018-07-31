using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (1 <= number && number <= 3)
            {
                Console.WriteLine(number * 10);
            }
            else if (4 <= number && number <= 6)
            {
                Console.WriteLine(number * 100);
            }
            else if (7 <= number && number <= 9)
            {
                Console.WriteLine(number * 1000);
            }
            else if (number < 0 || number > 9)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
