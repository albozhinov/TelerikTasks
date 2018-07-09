using System;
using System.Linq;
using System.Text;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "in";
            var text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimStart()).ToArray();
            string[] words = null;

            StringBuilder sb = new StringBuilder();            

            for (int i = 0; i < text.Length; i++)
            {
                words = text[i].Split(' ');

                if (words.Any(x => x == word))
                {
                    sb.Append(text[i] + ". ");
                }
            }
            Console.WriteLine(sb);            
        }
    }
}
