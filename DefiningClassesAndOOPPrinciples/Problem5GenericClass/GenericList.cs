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

        public T this[int indexer]
        {
            get
            {
                Validation(indexer);
                return this.myList[indexer];    
            }
            set
            {
                Validation(indexer);
                this.myList[indexer] = value;
            }
        }

        // Methods
        public void Validation(int index)
        {
            if (index < 0 || this.Count < index)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

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

        public void Remove(int index)
        {
            Validation(index);
            var newList = new T[this.Count - 1];
            int i = 0;
            int k = 0;

            while (k < this.Count - 1)
            {
                if (index == i)
                {
                    i++;
                }
                newList[k] = this.myList[i];
                i++;
                k++;
            }

            this.Count--;
            this.myList = newList;
        }

        public void Insert(int index, T element)
        {
            Validation(index);

            if (this.Count == this.Capacity)
            {
                DoubleSize();
            }

            int k = 0;
            int i = 0;
            var newList = new T[this.Count + 1];

            while (k <= this.Count)
            {
                if (k == index)
                {
                    newList[k] = element;                  
                    k++;
                    if (k > this.Count + 1)
                        break;
                }

                newList[k] = this.myList[i];
                i++;
                k++;
            }

            this.myList = newList;
            this.Count++;
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = 4;

            this.myList = new T[Count];
        }

        public int IndexOf(T value)
        {
            int index = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i].Equals(value))
                {
                    index = i;
                }
            }
            return index;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                if (i == Count - 1)
                {
                    sb.Append(myList[i]);
                    continue;
                }
                sb.Append(myList[i] + ", ");                    
            }
            return sb.ToString();
        }
    }
}
