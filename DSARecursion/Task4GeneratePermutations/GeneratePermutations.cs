using System;
using System.Text;

namespace Task4GeneratePermutations
{
    public class GeneratePermutations
    {
        static void Main(string[] args)
        {
            int n = 3;

            var sb = new StringBuilder();
            var permutations = new int[n];
            var used = new bool[n + 1];
            int index = 0;
            
            GenPermutations(sb, permutations, used, index);

            Console.WriteLine(sb.ToString());
        }
        public static void GenPermutations(StringBuilder sb, int[] permutations, bool[] used, int index)
        {
            if (index == permutations.Length)
            {
                sb.Append("{" + string.Format("{0}", string.Join(", ", permutations)) + "}, ");
                return;
            }

            for (int i = 1; i <= permutations.Length; i++)
            {
                if (!used[i])
                {
                    permutations[index] = i;

                    used[i] = true;
                    GenPermutations(sb, permutations, used, index + 1);

                    used[i] = false;
                }                
            }
        }
    }
}
