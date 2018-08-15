using System;
using System.Collections.Generic;
using System.Linq;

namespace P14LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myString = new List<string> { "Sasho", "Pesho", "Gosho", "Aleksandar", "Edo", "Steven", "Telerik", "Svetoslav", "Aleksander" };

            var longhestString = myString.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine(longhestString);

            var longhestString1 = myString.OrderByDescending(x => x.Length).First();
            Console.WriteLine(longhestString1);
        }
    }
}
