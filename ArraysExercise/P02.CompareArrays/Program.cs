using System;

namespace P02.CompareArrays
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[] firstArr = new int[size];
            int[] secArr = new int[size];
            string result = "Equal";

            for (int i = 0; i < size; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                secArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                if (firstArr[i] != secArr[i])
                {
                    result = "Not equal";
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine(result);
        }
    }
}
