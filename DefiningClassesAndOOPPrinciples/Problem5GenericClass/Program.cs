using System;

namespace Problem5GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {            

            GenericList<int> myList = new GenericList<int>();
            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ", myList.Capacity, myList.Count);

            // Test Count,Capacity and Add
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Adding 20 elements...\n");
            for (int i = 0; i < 20; i++)
            {
                myList.Add(i + 5);
            }

            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ", myList.Capacity, myList.Count);
            Console.WriteLine(myList);

            //Test  RemoveAt ,InsertAt and FIndIndex
            myList.Insert(5, 1111);
            myList.Insert(6, 2222);
            myList.Insert(7, 3333);

            myList.Remove(10);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--------GenericList--------");
            Console.WriteLine("Capacity: {0} , Count: {1} ", myList.Capacity, myList.Count);
            Console.WriteLine(myList);
            Console.WriteLine("\nThe element {0} is at {1} position.", 3333, myList.IndexOf(3333));
        }
    }
}
