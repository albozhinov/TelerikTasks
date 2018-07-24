using System;
using System.Linq;
using System.Collections.Generic;

namespace SubsetOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int index = 1;

            for (int i = 0; i < arr.Count; i++)
            {
                sum = arr[i];

                for (int k = i + index; k < arr.Count; k++)
                {
                    sum += arr[k];
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    else if (k == arr.Count - 1)
                    {
                        sum = arr[i];
                        index++;
                        k = i + index - 1;
                    }
                }
            }
            index = 1;
            sum = 0;
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                sum = arr[i];

                for (int k = arr.Count - 1 - index; k >= 0; k--)
                {
                    sum += arr[k];
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    else if (k == 0)
                    {
                        sum = arr[i];
                        index++;
                        k = arr.Count - index;
                    }
                }
            }
            index = 1;
            sum = 0;
            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                sum = arr[i];

                for (int k = i + index; k < arr.Count; k++)
                {
                    sum += arr[k];
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    else if (k == arr.Count - 1)
                    {
                        sum = arr[i];
                        index++;
                        k = i + index - 1;
                    }
                }
            }
            index = 1;
            sum = 0;
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                sum = arr[i];

                for (int k = arr.Count - 1 - index; k >= 0; k--)
                {
                    sum += arr[k];
                    if (sum == S)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                    else if (k == 0)
                    {
                        sum = arr[i];
                        index++;
                        k = arr.Count - index;
                    }
                }
            }
            Console.WriteLine("no");
        }
    }
}
