using System;
using System.Collections.Generic;
using System.Linq;

namespace BigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(firstArr.Length, secArr.Length); i++)
            {
                if (Math.Min(firstArr.Length, secArr.Length) < i)
                {
                    int sum = firstArr[i] + secArr[i];
                    if (true)
                    {

                    }
                    result.Add(firstArr[i] + secArr[i]);
                }
                else
                {
                    
                }
            }



        }
    }
}
