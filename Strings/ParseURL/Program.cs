using System;
using System.Text;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            //another input    "http://telerikacademy.com/Courses/Courses/Details/212"

            var line = "https://github.com/gentoo/gentoo.git".Split(new[] { ' ', '/', ':'}, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[protocol] = {line[0]}");
            sb.AppendLine($"[server] = {line[1]}");
            sb.Append($"[resource] = /{line[2]}");

            for (int i = 3; i < line.Length; i++)
            {
                sb.Append($"/{line[i]}");

            }
            Console.WriteLine(sb);
        }
    }
}
