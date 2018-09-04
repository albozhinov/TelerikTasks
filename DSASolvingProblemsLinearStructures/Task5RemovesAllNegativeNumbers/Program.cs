using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task5RemovesAllNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequenceDouble = new List<double>() { 2, 2.15, 3, 14, -3.14, 4, 5, -5.00, 10.00, -10 };
            var sequenceDecimal = new List<decimal>() { 2, 2.15M, 3, 14, -3.14M, 4, 5, -5.00M, 10.00M, -10 };
            var sequenceInt = new List<int>() { 2, -2, 3, -14, -3, 4, 5, -5, 10, -10 };            

            RemoveAllNegativeNumbers(sequenceDouble); 
            RemoveAllNegativeNumbers(sequenceDecimal);
            RemoveAllNegativeNumbers(sequenceInt);

            Console.WriteLine("Positive double numbers: " + string.Join(", ", sequenceDouble));
            Console.WriteLine("Positive decimal numbers: " + string.Join(", ", sequenceDecimal));
            Console.WriteLine("Positive integer numbers: " + string.Join(", ", sequenceInt));
        }
        public static void RemoveAllNegativeNumbers<T>(List<T> sequence)
        {            
            dynamic zero = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] < zero)
                {
                    sequence.RemoveAt(i);
                    i--;
                }                
            }            
        }
    }
}
