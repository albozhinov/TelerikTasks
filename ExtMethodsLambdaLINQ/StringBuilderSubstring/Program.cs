using P01StringBuilderSubstring;
using System;
using System.Text;

namespace StringBuilderSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nameAsASB = new StringBuilder("Alexander");
            string nameAsAString = "Alexander";

            nameAsASB = nameAsASB.StringBuilderSubstring(0, 4);
            nameAsAString = nameAsAString.Substring(0, 4);

            Console.WriteLine(nameAsASB);
            Console.WriteLine(nameAsAString);
        }        
    }
}
