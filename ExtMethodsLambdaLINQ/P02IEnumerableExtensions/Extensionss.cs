using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02IEnumerableExtensions
{
    public static class Extensionss
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            
            if (collection.Count() == 0){
                throw new ArgumentException("The collection is empty!");
            }

            T sum = (dynamic)0;

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        
        public static T Product<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0){
                throw new ArgumentException("The collection is empty!");
            }
            
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) 
            where T: IComparable, IConvertible
        {
            if (collection.Count() == 0){
                throw new ArgumentException("The collection is empty!");
            }

            T min = collection.Last();

            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) 
            where T: IComparable, IConvertible
        {
            if (collection.Count() == 0){
                throw new ArgumentException("The collection is empty!");
            }

            T max = collection.Last();

            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0){
                throw new ArgumentException("The collection is empty!");
            }

            double average = 0;

            average = collection.Aggregate(average, (x, y) => x + (dynamic)y) / collection.Count();
            return average;
        }
    }
}
