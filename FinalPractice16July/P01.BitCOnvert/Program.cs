using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BitCOnvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                            .Split(new[] { ' ', ',' }, 
                            StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            var binaryNums = new List<string>();

            for (int i = 0; i < inputNums.Length; i++)
            {
                string binary = Convert.ToString(inputNums[i], 2).PadLeft(8, '0');               
                binaryNums.Add(binary);
            }
            for (int i = 0; i < binaryNums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //string currNUm = binaryNums[0];
                    for (int p = 0; p < binaryNums[i].Length; p ++)
                    {
                        binaryNums[i] = binaryNums[i].Remove(p, 1);
                    }
                }
                else
                {
                    for (int p = 1; p < binaryNums[i].Length; p++)
                    {
                        binaryNums[i] = binaryNums[i].Remove(p, 1);
                    }
                }
            }
            Console.WriteLine(string.Join("", binaryNums));
        }
    }
}
