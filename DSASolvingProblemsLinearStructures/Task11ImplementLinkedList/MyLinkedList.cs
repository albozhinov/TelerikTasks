using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task11ImplementLinkedList
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        // Field
        private ListItem<T> head;
        private ListItem<T> tail;
        
        // Properties
        public ListItem<T> FirstElement { get => this.head; }

        public int Count
        {
            get
            {
                var currentElement = this.head;
                int itemsCount = 0;
                while (currentElement != null)
                {
                    itemsCount++;
                    currentElement = currentElement.NextItem;
                }
                return itemsCount;
            }
        }

        // Methods
        public void AddLast(T value)
        {
            var elementToAdd = new ListItem<T>(value);
            if (this.head == null)
            {
                this.head = elementToAdd;
                this.tail = elementToAdd;
            }
            else
            {
                this.tail.NextItem = elementToAdd;
                this.tail = elementToAdd;
            }
        }

        public void AddFirst(T value)
        {
            var elementToAdd = new ListItem<T>(value);
            if (this.head == null)
            {
                this.head = elementToAdd;
                this.tail = elementToAdd;
            }
            else
            {
                elementToAdd.NextItem = this.head;
                this.head = elementToAdd;                
            }
        }

        public void RemoveFirst()
        {
            this.head = this.head.NextItem;
        }

        public void RemoveLast()
        {
            var element = this.head;

            while (element.NextItem.NextItem != null)
            {
                element = element.NextItem;
            }
            element.NextItem = null;
            this.tail = element;
        }

        public void Remove(T value)
        {
            if (this.head != null && value.Equals(this.head.Value))
            {
                this.head = this.head.NextItem;
                return;
            }

            var element = this.head;
            while (element != null)
            {
                if (element.NextItem.Value.Equals(value))
                {
                    element.NextItem = element.NextItem.NextItem;
                    break;
                }
                element = element.NextItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currElement = this.head;
            while (currElement != null)
            {
                yield return currElement.Value;
                currElement = currElement.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
