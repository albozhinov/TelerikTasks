using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Swappings
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        // Fields
        private T value;
        private MyLinkedList<T> leftElement;
        private MyLinkedList<T> rightElement;

        // Constructor
        public MyLinkedList(T value)
        {
            this.value = value;
            this.leftElement = null;
            this.rightElement = null;
        }

        // Propeties 
        public MyLinkedList<T> LeftElement => this.leftElement;

        public MyLinkedList<T> RightElement => this.rightElement;

        public T Value => this.value;

        // Methods
        public void AddLast(MyLinkedList<T> right)
        {
            this.rightElement = right;
            right.leftElement = this;
        }

        public void Remove()
        {
            if (this.leftElement != null)
            {
                this.leftElement.rightElement = null;
                this.leftElement = null;
            }
            if (this.rightElement != null)
            {
                this.rightElement.leftElement = null;
                this.rightElement = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var element = this;
            while (element != null)
            {
                yield return element.Value;

                element = element.RightElement;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Swappings
    {
        static void Main(string[] args)
        {
            // Задачата не може да се реши с "държавната" имплементация на линейната структура LinkedList
            // за целта ние ще имплементираме наш LinkedList, понеже връзките Previous и Next са readonly!!!
            int N = int.Parse(Console.ReadLine());

            var nodes = Enumerable.Range(0, N + 1)
                                  .Select(x => new MyLinkedList<int>(x))
                                  .ToArray();

            for (int i = 1; i < N; i++)
            {
                nodes[i].AddLast(nodes[i + 1]);
            }

            var first = nodes[1];
            var last = nodes[N];

            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList()
            .ForEach(num =>
            {
                var currLast = nodes[num].LeftElement;
                var currFirst = nodes[num].RightElement;

                nodes[num].Remove();

                if (last != nodes[num])
                {
                    last.AddLast(nodes[num]);
                }
                else
                {
                    currFirst = nodes[num];
                }

                if (first != nodes[num])
                {
                    nodes[num].AddLast(first);
                }
                else
                {
                    currLast = nodes[num];
                }

                first = currFirst;
                last = currLast;
            });
            
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
