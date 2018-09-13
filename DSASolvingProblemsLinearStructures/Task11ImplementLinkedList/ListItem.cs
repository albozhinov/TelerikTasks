using System;
using System.Collections.Generic;
using System.Text;

namespace Task11ImplementLinkedList
{
    public class ListItem<T>
    {
        // Constructor
        public ListItem(T value)
        {
            this.Value = value;
        }

        // Properties
        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
