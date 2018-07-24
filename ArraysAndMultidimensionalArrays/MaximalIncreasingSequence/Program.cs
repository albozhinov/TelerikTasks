using System;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int num;
            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            int counter = 1;
            int maxCounter = 1;

            for (int i = 0; i < N - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
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
