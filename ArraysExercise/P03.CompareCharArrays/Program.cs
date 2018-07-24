using System;
using System.Linq;

namespace P03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCharArr = Console.ReadLine().ToCharArray();
            var secCharArr = Console.ReadLine().ToCharArray();

            int firstSum = 0;
            int secSum = 0;

            for (int i = 0; i < firstCharArr.Length; i++)
            {
                firstSum += (int)firstCharArr[i];
            }
            for (int i = 0; i < secCharArr.Length; i++)
            {
                secSum += (int)secCharArr[i];
            }
            if (firstSum < secSum)
            {
                Console.WriteLine("<");
                return;
            }
            else if (firstSum > secSum)
            {
                Console.WriteLine(">");
                return;
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
