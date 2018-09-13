using System;
using System.Collections.Generic;

namespace Task6PrintAllElementsPermutanions
{
    class PrintAllPermutation
    {
        private static string[] elements = new string[3] { "test", "rock", "fun" };
        private static int k = 2;
        private static string[] printElemnts = new string[k];        
        private static HashSet<string> set = new HashSet<string>();

        static void Main(string[] args)
        {
            PrintPermutation(0, 0);
            Console.WriteLine(string.Join(", ", set));
        }
        private static void PrintPermutation(int index, int start)
        {
            if (index >= k)
            {
                set.Add(string.Format("({0})", string.Join(" ", printElemnts)));
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                
                printElemnts[index] = elements[i];
                PrintPermutation(index + 1, start + 1);
            }
        }
    }
}
