using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GirlsGoneWild
{
    class GirlsGoneWild
    {
        private static int totalPeople;
        private static List<List<int>> combOfNumbers = new List<List<int>>();
        private static List<List<char>> combOfLetters = new List<List<char>>();
        private static SortedSet<string> permutation = new SortedSet<string>();

        static void Main(string[] args)
        {
            var numbers = new int[int.Parse(Console.ReadLine())];
            char[] letters = Console.ReadLine().ToCharArray();
            totalPeople = int.Parse(Console.ReadLine());

            Comb(numbers, 0, 0, comb =>
            {
                combOfNumbers.Add(new List<int>(comb));
            });

            numbers = new int[letters.Length];

            Comb(numbers, 0, 0, comb =>
            {
                var currLetterComb = new List<char>();

                for (int i = 0; i < totalPeople; i++)
                {
                    currLetterComb.Add(letters[comb[i]]);
                }

                combOfLetters.Add(currLetterComb);
            });

            foreach (var numberComb in combOfNumbers)
            {

                foreach (var letterComb in combOfLetters)
                {
                    var newLetter = new List<char>(letterComb);

                    PermuteRep(letterComb, 0, perm =>
                    {
                        Merge(perm, numberComb);
                    });
                }
            }
            var result = new StringBuilder();
            result.AppendLine(permutation.Count.ToString());
            foreach (var item in permutation)
            {
                result.AppendLine(item);
            }
            Console.Write(result.ToString());
        }

        public static void Merge(List<char> letter, List<int> numbers)
        {
            var result = new StringBuilder();

            for (int i = 0; i < letter.Count; i++)
            {
                result.Append(numbers[i]);
                result.Append(letter[i]);
                result.Append('-');
            }

            result.Length--;
            permutation.Add(result.ToString());
        }

        public static void Comb(int[] arr, int index, int start, Action<int[]> action)
        {
            if (index >= totalPeople)
            {
                action(arr);
                return;
            }
            else
            {
                for (int i = start; i < arr.Length; i++)
                {
                    arr[index] = i;
                    Comb(arr, index + 1, i + 1, action);
                }
            }
        }

        public static void PermuteRep(List<char> arr, int start, Action<List<char>> action)
        {
            action(arr);

            for (int left = arr.Count - 2; left >= start; left--)
            {
                for (int right = left + 1; right < arr.Count; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        var oldValue = arr[left];
                        arr[left] = arr[right];
                        arr[right] = oldValue;

                        PermuteRep(arr, left + 1, action);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i < arr.Count - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Count - 1] = firstElement;
            }
        }
    }
}
