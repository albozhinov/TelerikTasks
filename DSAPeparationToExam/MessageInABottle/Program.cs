using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageInABottle
{
    class Program
    {
        public static List<KeyValuePair<char, string>> kvp = new List<KeyValuePair<char, string>>();
        public static StringBuilder sb = new StringBuilder();
        public static int conter = 0;        

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string lettersAndDigits = Console.ReadLine();

            char key = char.MinValue;
            string value = "";

            for (int i = 0; i < lettersAndDigits.Length; i++)
            {
                if (lettersAndDigits[i] >= 'A' && lettersAndDigits[i] <= 'Z')
                {
                    if (value != "")
                    {
                        kvp.Add(new KeyValuePair<char, string>(key, value));
                        value = "";
                    }
                    key = lettersAndDigits[i];                    
                }
                else
                {
                    value += lettersAndDigits[i];
                }
            }
            kvp.Add(new KeyValuePair<char, string>(key, value));
        }

        public static void Solve(int index, string message)
        {
            // Bottom
            if (true)
            {

            }

            foreach (var item in collection)
            {

            }


        }
    }
}
