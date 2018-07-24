using System;

namespace P04.MaximumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var counter = 1;
            var maxCounter = 1;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (i > 0 && numbers[i] == numbers[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }                   
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(maxCounter);
        }
    }
}
