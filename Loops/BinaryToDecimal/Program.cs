using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryNum = Console.ReadLine().ToCharArray();
            long decimalNum = 0;

            for (int i = 0; i < binaryNum.Length; i++)
            {
                if (binaryNum[binaryNum.Length - 1 - i] == '0')
                {
                    continue;
                }
                decimalNum += (long)Math.Pow(2, i);
            }
            Console.WriteLine(decimalNum);
        }
    }
}
