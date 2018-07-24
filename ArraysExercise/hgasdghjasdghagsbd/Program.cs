﻿using System;
using System.Linq;
namespace hgasdghjasdghagsbd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers separated by a comma: ");
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            var number = (from numbers in inputNumbers
                          group numbers by numbers into gr
                          orderby gr.Count() descending
                          select new { Number = gr.Key, Frequency = gr.Count() }).First();

            Console.WriteLine("The most frequent number is {0} ({1} times)",
                number.Number, number.Frequency);
        }
    }
}
