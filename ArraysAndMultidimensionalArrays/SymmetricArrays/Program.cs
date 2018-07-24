using System;
using System.Linq;
using System.Text;

namespace SymmetricArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArr = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < countOfArr; i++)
            {
                var inputLine = Console.ReadLine().Split(' ').ToArray();

                if (inputLine.Length == 1) { sb.AppendLine("Yes"); }

                for (int r = 0; r < inputLine.Length / 2; r++)
                {
                    if (inputLine[r] != inputLine[inputLine.Length - 1 - r])
                    {
                        sb.AppendLine("No");
                        break;
                    }
                    if (r == (inputLine.Length / 2) - 1)
                    {
                        sb.AppendLine("Yes");
                    }
                }                
            }
            Console.Write(sb);
        }
    }
}
