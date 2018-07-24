﻿using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
