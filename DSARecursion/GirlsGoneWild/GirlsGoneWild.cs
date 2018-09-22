using System;
using System.Collections.Generic;
using System.Text;

namespace GirlsGoneWild
{
    class GirlsGoneWild
    {
        private static int number;
        private static char[] letters;
        private static int girls;        
        private static StringBuilder sb = new StringBuilder();
        private static SortedSet<string> allCombinations;
        private static bool[] isTrue = new bool[letters.Length];

        static void Main(string[] args)
        {
            number = 3;                       //int.Parse(Console.ReadLine());
            letters = "aabc".ToCharArray();   //Console.ReadLine(); Sort
            girls = 2;                        //int.Parse(Console.ReadLine());
            
            NumberComb(0, 0, number);            
        }

        public static void NumberComb(int index, int start, int end)
        {
            if (index == end)
            {                
                return;
            }

            for (int i = start; i <= end; i++)
            {
                var comb = // Виж как ще го направиш за да може тук да се генерира комбинацията от число и буква!!!

                NumberComb(index + 1, start + 1, end); 
                start++;
            }
        }
    }
}
