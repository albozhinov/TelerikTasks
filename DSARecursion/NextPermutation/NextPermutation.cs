using System;
using System.Collections.Generic;
using System.Linq;

namespace NextPermutation
{
    public class NextPermutation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var currPermutation = Console.ReadLine();
            try
            {
                Swap(currPermutation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Swap(string currPerputation)
        {
            var splitted = currPerputation.Split().Select(int.Parse).ToList();
            var k = splitted.Count - 2;

            // Find greater index K
            while (!(splitted[k] < splitted[k + 1]))
            {
                k--;
            }

            int currElement;
            int biggestElement;

            // Find greater index I
            int I = k + 2;
            if (I < splitted.Count)
            {                
                while (!(splitted[k] < splitted[I]))
                {                
                    I++;
                    if (splitted.Count == I)
                    {                       
                        break;
                    }
                }
                if (I == splitted.Count)
                {
                    currElement = splitted[k];
                    biggestElement = splitted[k + 1];

                    // Swapped elements
                    splitted[k] = biggestElement;
                    splitted[k + 1] = currElement;
                }
                else
                {
                    currElement = splitted[k];
                    biggestElement = splitted[I];

                    // Swapped elements
                    splitted[k] = biggestElement;
                    splitted[I] = currElement;
                }                
            }
            else
            {
                currElement = splitted[k];
                biggestElement = splitted[k + 1];

                // Swapped elements
                splitted[k] = biggestElement;
                splitted[k + 1] = currElement;
            }     

            // Reversed by Stack
            var stack = new Stack<int>();
            for (int i = k + 1; i < splitted.Count; i++)
            {
                stack.Push(splitted[i]);
            }

            while (stack.Count != 0)
            {
                splitted[k + 1] = stack.Pop();
                k++;
            }            
            Console.WriteLine(string.Join(" ", splitted));
        }
    }
}
