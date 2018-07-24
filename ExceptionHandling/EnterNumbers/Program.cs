using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new int[10];
            int start = 1;

            for (int i = 0; i < 10; i++)
            {
                int end = int.Parse(Console.ReadLine());
                ReadNumber(start, end);
                result[i] = start;
                start = end;
            }
            Console.WriteLine(string.Join(" < ", result));
        }

        private static void ReadNumber(int start, int end)
        {

            bool isTrue = start < end;
            if (isTrue)
            {
                return;
            }
            else
            {
                Console.WriteLine("Exception");
                Environment.Exit(0);
            }
        }
    }
}
