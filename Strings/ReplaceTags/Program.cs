using System;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>";
            // <a href="URL">TEXT</a>

            while (text.Contains("<a href="))
            {
                int startIndex = text.IndexOf("<a href=");
                int endIndex = text.IndexOf(">");
                int lenght = endIndex - startIndex;
                string subs = text.Substring(startIndex,);






               
                int endIndex1 = text.IndexOf("<");






            }




        }
    }
}
