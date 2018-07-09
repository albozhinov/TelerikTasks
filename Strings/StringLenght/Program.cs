using System;

namespace StringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            int textLenght = 20;
            var text = Console.ReadLine();

            while (text.Length < 20)
            {
                text += "*";
            }            
            Console.WriteLine(text);
        }
    }
}
