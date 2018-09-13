using System;
using System.Collections;
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
            var stack = new Stack<int>();
            var result = new int[buildings.Count];


            for (int i = buildings.Count - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && buildings[stack.Peek()] <= buildings[i])
                {
                    int index = stack.Pop();
                    result[index] = stack.Count;
                }
                stack.Push(i);
            }
            while (stack.Count != 0)
            {
                int index = stack.Pop();
                result[index] = stack.Count;
            }
            Console.WriteLine(result.Max());
            Console.WriteLine(string.Join(" ", result));           
        }
    }
}
