using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            var sign = "-";

            if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                sign = "+";
            }
            if (num1 > 0 && num2 < 0 && num3 < 0)
            {
                sign = "+";
            }
            if (num1 < 0 && num2 > 0 && num3 < 0)
            {
                sign = "+";
            }
            if (num1 < 0 && num2 < 0 && num3 > 0)
            {
                sign = "+";
            }
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                sign = "0";
            }

            Console.WriteLine(sign);
        }
    }
}
