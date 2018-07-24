using System;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine().ToCharArray();
            var word2 = Console.ReadLine().ToCharArray();

            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                sum1 += word1[i];
            }

            for (int i = 0; i < word2.Length; i++)
            {
                sum2 += word2[i];
            }

            if (sum1 > sum2)
            {
                Console.WriteLine(">");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
