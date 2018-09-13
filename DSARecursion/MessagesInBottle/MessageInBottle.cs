using System;
using System.Collections.Generic;
using System.Text;

namespace MessagesInBottle
{
    class MessageInBottle
    {
        private static List<KeyValuePair<char, string>> ciphers = new List<KeyValuePair<char, string>>();
        private static string message;

        static void Main(string[] args)
        {
            message = Console.ReadLine();
            string cipher = Console.ReadLine();

            char key = char.MinValue;
            string value = string.Empty;
            for (int i = 0; i < cipher.Length; i++)
            {
                if ('A' <= cipher[i] && cipher[i] <= 'Z')
                {
                    if (value != "")
                    {
                        ciphers.Add(new KeyValuePair<char, string>(key, value));
                        value = "";
                    }
                    key = cipher[i];
                }
                else
                {
                    value += cipher[i];
                }
            }
            ciphers.Add(new KeyValuePair<char, string>(key, value));

            StringBuilder sb = new StringBuilder();
            FindsAllPossibleOriginalMessages(sb, 0);            

            var printSb = new StringBuilder();

            printSb.AppendLine(originalMsg.Count.ToString());

            foreach (var item in originalMsg)
            {
                printSb.AppendLine(item);
            }

            Console.Write(printSb.ToString());
        }

        private static SortedSet<string> originalMsg = new SortedSet<string>();        

        public static void FindsAllPossibleOriginalMessages(StringBuilder sb, int index)
        {
            if (index == message.Length)
            {
                originalMsg.Add(sb.ToString());
                return;
            }
            foreach (var cipher in ciphers)
            {
                if (message.Substring(index).StartsWith(cipher.Value))
                {
                    sb.Append(cipher.Key);
                    FindsAllPossibleOriginalMessages(sb, index + cipher.Value.Length);
                    sb.Length--;
                }               
            }
        }
    }
}
