using System;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            // <a href="URL">TEXT</a>

            // output --> <p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>
            //string URL = $"({})";
            //var URLindex = 0;
            Console.WriteLine(text);
            Console.WriteLine("\n\n");
            Console.WriteLine(new string('=', 100));

            while (text.Contains("<a href=\""))
            {
                int startIndex = text.IndexOf("<a href=\"");
                int endIndex = text.IndexOf("\">");
                int lenght = endIndex - startIndex;

                string subs = text.Substring(startIndex, lenght);
                string URL = text.Substring(startIndex + 9, lenght - 9);
                URL = $"({URL})";

                text = text.Replace(subs, URL);

                int fWord = text.IndexOf("\">");
                int sWord = text.IndexOf("</a>") + 4;
                int wordLen = sWord - fWord;

                string wordSubs = text.Substring(fWord, wordLen);
                text = text.Replace(wordSubs, "");

                string word = wordSubs.Substring(2, wordSubs.Length - 6);
                word = $"[{word}]";

                int brace = text.IndexOf(URL);
                text = text.Insert(brace, word);
            }
            Console.WriteLine(text);
        }
    }
}
