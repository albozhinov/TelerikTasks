using System;
using System.Collections.Generic;
using System.Linq;

namespace Task11ImplementLinkedList
{
    class Startup
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            var myList = new MyLinkedList<int>();

            for (int i = 1; i <= 20; i++)
            {
                list.AddLast(i);
                myList.AddLast(i);
            }

            list.Remove(15);
            myList.Remove(15);

            list.RemoveFirst();
            myList.RemoveFirst();

            list.RemoveLast();
            myList.RemoveLast();

            list.AddFirst(100);
            myList.AddFirst(100);

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(string.Join(", ", myList));
        }
    }
}
