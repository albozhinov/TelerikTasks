using System;
using System.Linq;

namespace MostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            int maxCounter = 0;
            int mostFrequent = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            mostFrequent = input[j];
                        }
                    }                    
                }
                counter = 1;
            }
            Console.WriteLine($"{mostFrequent}({maxCounter} times)");
        }
    }
}
