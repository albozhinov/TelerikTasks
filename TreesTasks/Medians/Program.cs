using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Medians
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            string nextLine;
            string[] splitText;
            var numbers = new BigList<int>();

            while ((nextLine = Console.ReadLine()) != "EXIT")
            {
                splitText = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (splitText[0])
                {
                    case "ADD":
                        var num = int.Parse(splitText[1]);
                        numbers.Add(num);
                        break;
                    case "FIND":
                        FindCommand(numbers);
                        break;
                }
            }
            Console.Write(sb.ToString());
        }

        private static void FindCommand(BigList<int> numbers)
        {
            if (numbers.Count % 2 == 0)
            {
                double median = (numbers[numbers.Count / 2] + numbers[(numbers.Count / 2) - 1]) / 2.0;
                sb.AppendLine(median.ToString());
            }
            else
            {
                sb.AppendLine(numbers[numbers.Count / 2].ToString());
            }
        }
    }
}
