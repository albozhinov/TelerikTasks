using System;

namespace BiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());  // BiggestOfThree
            var num2 = double.Parse(Console.ReadLine());  // BiggestOfThree
            var num3 = double.Parse(Console.ReadLine());  // BiggestOfThree
            var num4 = double.Parse(Console.ReadLine());  // BiggestOfFive
            var num5 = double.Parse(Console.ReadLine());  // BiggestOfFive

            double result = double.MinValue;

            if (num1 > result)
            {
                result = num1;
            }
            if (num2 > result)
            {
                result = num2;
            }
            if (num3 > result)
            {
                result = num3;
            }
            if (num4 > result)
            {
                result = num4;
            }
            if (num5 > result)
            {
                result = num5;
            }
            Console.WriteLine(result);
        }
    }
}
