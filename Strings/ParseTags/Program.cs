using System;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string tag1 = "<upcase>";
            string tag2 = "</upcase>";

            while (text.Contains(tag1))
            {
                int startIndex = text.IndexOf(tag1);
                int endIndex = text.IndexOf(tag2) + tag2.Length;
                int lenght = endIndex - startIndex;
                string substring = text.Substring(startIndex, lenght);
                string newSubstring = text.Substring(startIndex + tag1.Length, lenght - (tag2.Length + tag1.Length));

                text = text.Replace(substring, newSubstring.ToUpper());
            }
            Console.WriteLine(text);
        }
    }
}
