using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsOrder
{
    class StudentsOrder
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split().ToArray();
            string[] studentsName = Console.ReadLine().Split().ToArray();

            int n = int.Parse(inputLine[0]);
            int k = int.Parse(inputLine[1]);

            var orederStudents = new LinkedList<string>();
            var nodes = new Dictionary<string, LinkedListNode<string>>();

            for (int i = 0; i < n; i++)
            {
                var node = orederStudents.AddLast(studentsName[i]);
                nodes.Add(node.Value, node);
            }

            for (int i = 0; i < k; i++)
            {
                var names = Console.ReadLine().Split();
                string left = names[0];
                string right = names[1];

                var nodeToRemove = nodes[left];
                var nodeToPush = nodes[right];

                orederStudents.Remove(nodeToRemove);
                orederStudents.AddBefore(nodeToPush, nodeToRemove);
            }

            Console.WriteLine(string.Join(" ", orederStudents));
        }
    }
}
