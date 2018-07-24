using System;
using System.Text;

namespace PrintDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = Console.ReadLine();

            int face;
            switch (N)
            {
                case "A":
                    face = 15;
                    break;
                case "J":
                    face = 12;
                    break;
                case "Q":
                    face = 13;
                    break;
                case "K":
                    face = 14;
                    break;
                default:
                    face = int.Parse(N);
                    break;
            }            

            StringBuilder sb = new StringBuilder();
            
            for (int i = 2; i <= face; i++)
            {
                if (i <= 10)
                {
                    sb.AppendLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
                }
                else if (i == 12)
                {
                    sb.AppendLine($"J of spades, J of clubs, J of hearts, J of diamonds");
                }
                else if (i == 13)
                {
                    sb.AppendLine($"Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                }
                else if (i == 14)
                {
                    sb.AppendLine($"K of spades, K of clubs, K of hearts, K of diamonds");
                }
                else if (i == 15)
                {
                    sb.AppendLine($"A of spades, A of clubs, A of hearts, A of diamonds");
                }
            }
            Console.Write(sb);
        }
    }
}
