using System;
using System.Collections.Generic;
using System.Text;

namespace Task5GenerateAndPrintAllOrderedKElements
{
    class GenerateAndPrint
    {
        // Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
        private static int n = 3;
        private static int k = 2;
        private static List<string> elements = new List<string>() { "hi", "a", "b" };
        private static HashSet<string> set = new HashSet<string>();

        static void Main(string[] args)
        {
            var printElement = new string[2];
            GenerateAllOrderedElements(0, printElement);
            Console.WriteLine(string.Join(", ", set));
        }
        private static void GenerateAllOrderedElements(int index, string[] printElements)
        {
            if (index == k)
            {
                set.Add(string.Format("({0})", string.Join(" ", printElements)));                    
                return;
            }

            for (int i = 0; i < n; i++)
            {
                printElements[index] = elements[i];
                GenerateAllOrderedElements(index + 1, printElements);
            }
        }
    }
}
