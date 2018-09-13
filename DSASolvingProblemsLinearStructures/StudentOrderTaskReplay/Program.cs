using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentOrderTaskReplay
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var names = Console.ReadLine().Split().ToList();

            int studentsCount = input[0];
            int seatsCount = input[1];

            var linkedList = new LinkedList<string>();
            var dict = new Dictionary<string, LinkedListNode<string>>();

            for (int i = 0; i < studentsCount; i++)
            {
                var node = linkedList.AddLast(names[i]);
                dict.Add(node.Value, node);
            }

            for (int i = 0; i < seatsCount; i++)
            {
                var seat = Console.ReadLine().Split();

                var left = seat[0];
                var right = seat[1];

                var nodeToRemove = dict[left];
                var nodeToPush = dict[right];

                linkedList.Remove(nodeToRemove);
                linkedList.AddBefore(nodeToPush, nodeToRemove);                
            }
            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}
