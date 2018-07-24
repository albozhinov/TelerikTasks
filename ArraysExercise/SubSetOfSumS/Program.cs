using System;
using System.Linq;

namespace SubSetOfSumS
{
    class Program
    {
        static void Main()
        {
            int S = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int index = 1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];

                for (int k = i + index; k < arr.Length; k++)
                {
                    sum += arr[k];

                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    else if (k == arr.Length - 1)
                    {
                        sum = arr[i];
                        index++;
                        k = i + index - 1;
                    }
                }
            }
            Console.WriteLine("no");
        }
    }
}
