using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5GenericClass
{
    class GenericList<T>
    {
        // Fields
        private T[] myList;
        private int capacity = 4;
        private int count = 0;

        // Constructort
        public GenericList()
        {            
            this.myList = new T[capacity];
        }

        public GenericList(int capacity)
            : this()
        {
            this.Capacity = capacity;
            this.myList = new T[this.Capacity];
        }

        // Properties
        public int Capacity
        {
            get => this.capacity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                if (value < this.myList.Length)
                {
                    this.capacity = this.myList.Length;
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public int Count { get => this.count; set => this.count = value; }

        // Methods
        public void DoubleSize()
        {
            int newSize = this.myList.Length * 2;
            T[] newList = new T[newSize];

            for (int i = 0; i < this.myList.Length; i++)
            {
                newList[i] = this.myList[i];
            }

            this.myList = newList;
            this.Capacity *= 2;
        }

        public void Add(T elementToAdd)
        {
            if (Count == this.myList.Length)
            {
                DoubleSize();
            }
            this.myList[Count] = (elementToAdd);
            this.Count++;
        }



    }
}
