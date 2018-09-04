using System;
using System.Collections.Generic;

namespace Task4FindTheLongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 1, 1, 1, 1, 2, 3, 1, 4, 3, 2, 5, 6, 7, 8, 8, 8, 8, 8 };

            var result = FindLongestSequence(sequence);

            Console.WriteLine(string.Join(", ", result));
        }

        public static List<int> FindLongestSequence(List<int> sequence)
        {
            int counter = 1;
            int maxCounter = 1;
            int startIndex = 0;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                    if (maxCounter < counter)
                    {
                        maxCounter = counter;
                        startIndex = i + 2 - maxCounter;
                    }
                }
                else
                {
                    counter = 1;
                }

            }
            var mostEqualSequence = new List<int>();

            for (int i = 0; i < maxCounter; i++)
            {
                mostEqualSequence.Add(sequence[startIndex + i]);
            }

            return mostEqualSequence;
        }
    }
}
