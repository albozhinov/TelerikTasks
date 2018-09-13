using System;
using System.Text;

namespace Permutations
{
    class Permutation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            var permutations = new int[n];
            var used = new bool[n + 1];
            int index = 0;

            GenPermutation(sb, permutations, used, index); 

            Console.Write(sb.ToString());
        }
        public static void GenPermutation(StringBuilder sb, int[] permutations, bool[] used, int index)
        {
            if (index == permutations.Length)
            {
                sb.AppendLine(string.Join(" ", permutations));
                return;
            }
            for (int i = 1; i <= permutations.Length; i++)
            {
                if (!used[i])
                {
                    permutations[index] = i;
                    used[i] = true;

                    GenPermutation(sb, permutations, used, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
