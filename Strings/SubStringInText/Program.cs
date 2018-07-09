using System;
using System.Linq;
using System.Text;

namespace SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordToSearch = Console.ReadLine();
            var text = Console.ReadLine();
            int counter = 0;

            while (text.Contains(wordToSearch))
            {
                counter++;
                int startIndex = text.IndexOf(wordToSearch);
                text = text.Remove(startIndex, wordToSearch.Length);
            }
            Console.WriteLine(counter);
        }
    }
}
