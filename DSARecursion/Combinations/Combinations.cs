using System;
using System.Linq;
using System.Text;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int N = nums[0];
            int K = nums[1];

            var sb = new StringBuilder();
            var generatComb = new int[K];

            GenCombinations(generatComb, sb, 0, 1, N);

            Console.Write(sb.ToString());
        }

        public static void GenCombinations(int[] combination, StringBuilder sb, int index, int start, int end)
        {
            if (index == combination.Length)
            {
                sb.AppendLine(string.Join(" ", combination));
                return;
            }
            for (int i = start; i <= end; i++)
            {                
                combination[index] = i;

                GenCombinations(combination, sb, index + 1, start + 1, end); // В рекурсивното извикване ако не добавяме 1 към start 
                                                                             // това ще ни реши задача "Combinations with Repetitions"!
                start++;
            }            
        }
    }
}
