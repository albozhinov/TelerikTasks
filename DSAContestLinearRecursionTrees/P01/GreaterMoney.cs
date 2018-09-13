using System;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBag = Console.ReadLine()
                           .Split(new char[] { ',' }, 
                           StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            var secondtBag = Console.ReadLine()
                           .Split(new char[] { ',' },
                           StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToList();

            bool flag = true;
            int currIndex = 0;
            for (int f = 0; f < firstBag.Length; f++)
            {
                flag = true;                
                for (int i = 0; i < secondtBag.Count; i++)
                {
                    if (firstBag[f] == secondtBag[i])
                    {
                        currIndex = i;
                    }
                }

                for (int s = currIndex; s < secondtBag.Count; s++)
                {
                    if (firstBag[f] < secondtBag[s])
                    {
                        firstBag[f] = secondtBag[s];
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    firstBag[f] = -1;
                }
            }
            Console.WriteLine(string.Join(",", firstBag));
        }
    }
}
