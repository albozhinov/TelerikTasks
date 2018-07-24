using System;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int counter = 1;
            int maxCounter = 1;

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < N - 1; i++)
            {
                arr[i] = number;
                number = int.Parse(Console.ReadLine());
                if (arr[i] == number)
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
