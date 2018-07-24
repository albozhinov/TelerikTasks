using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int number = int.Parse(Console.ReadLine());
            array[0] = number;
            int counter = 1;
            int maxCounter = 1;

            for (int i = 1; i < N; i++)
            {
                number = int.Parse(Console.ReadLine());
                array[i] = number;

                if (array[i - 1] == array[i])
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
