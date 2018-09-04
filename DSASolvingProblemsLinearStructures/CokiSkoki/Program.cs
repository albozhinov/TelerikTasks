using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CokiSkoki
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsOfBuildings = int.Parse(Console.ReadLine());
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var jumps = new int[numsOfBuildings];
           
            var stack = new Stack<int>();

            for (int i = numsOfBuildings; i >= 0; i--)
            {       
                stack.Push(i);
                while (buildings[stack.Peek()] <= buildings[i])
                {
                    int peekIndex = stack.Pop();
                    jumps[peekIndex] = stack.Count();
                }
            }
            Console.WriteLine(jumps.Max());
            Console.WriteLine(string.Join(" ", jumps));
        }
    }
}
