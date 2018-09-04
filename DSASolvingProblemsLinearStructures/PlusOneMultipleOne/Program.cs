using System;
using System.Linq;
using System.Collections.Generic;

namespace PlusOneMultipleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = inputLine[0];
            var M = inputLine[1];

            var sequence = new Queue<int>();

            sequence.Enqueue(N);
            var currNum = 0;
            var counter = 1;

            while (counter < M)
            {
                currNum = sequence.Dequeue();
                counter++;
                sequence.Enqueue(currNum + 1);
                sequence.Enqueue(2 * currNum + 1);
                sequence.Enqueue(currNum + 2);
            }

            Console.WriteLine(sequence.Peek());
        }       
    }
}
