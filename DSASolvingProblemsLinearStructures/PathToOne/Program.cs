using System;
using System.Collections.Generic;
using System.Linq;

namespace PathToOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            var arr = new int[] { int.MaxValue };


            FindPathToOne(arr, N, 1, 0);

            Console.WriteLine(arr[0]);
        }

        public static void FindPathToOne(int[] result, long start, int end, int counter)
        {
            if (end >= start)
            {
                if (counter < result[0] && end == start)
                {
                    result[0] = counter;
                }
                return;
            }

            if (start % 2 == 0)
            {
                start /= 2;
                counter++;
                FindPathToOne(result, start, end, counter);
            }
            else if (((start - 1) / 2) % 2 == 0 || start == 3)
            {
                start--;
                counter++;
                FindPathToOne(result, start, end, counter);
            }
            else if (((start + 1) / 2) % 2 == 0)
            {
                start++;
                counter++;
                FindPathToOne(result, start, end, counter);
            }
            return;
        }
    }
}
