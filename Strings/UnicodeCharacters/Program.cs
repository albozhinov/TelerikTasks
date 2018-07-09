using System;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var hex = Convert.ToInt32(inputLine[i]);
                Console.Write("\\u00" + string.Format("{0:X}", hex));
            }
            Console.WriteLine();
        }
    }
}
