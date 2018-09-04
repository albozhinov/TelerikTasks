using System;
using System.Collections.Generic;
using System.Linq;

namespace JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfJedi = int.Parse(Console.ReadLine());
            var jedis = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var masters = new Queue<string>();
            var knights = new Queue<string>();
            var padawans = new Queue<string>();

            for (int i = 0; i < numberOfJedi; i++)
            {
                var currJedi = jedis[i];

                if (currJedi[0] == 'M')
                {
                    masters.Enqueue(currJedi);
                }
                else if (currJedi[0] == 'K')
                {
                    knights.Enqueue(currJedi);
                }
                else
                {
                    padawans.Enqueue(currJedi);
                }
            }

            PrintJedi(masters);
            PrintJedi(knights);
            PrintJedi(padawans);
        }
        public static void PrintJedi(Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                Console.Write(queue.Peek() + " ");
                queue.Dequeue();
            }
        }
    } 
}
