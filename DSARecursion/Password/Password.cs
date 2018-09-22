using System;

namespace Password
{
    class Password
    {
        private static int N;
        private static int K;
        private static char[] symbols;
        private static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private static int counter = 0;

        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            symbols = Console.ReadLine().ToCharArray();
            K = int.Parse(Console.ReadLine());

            
            FindPassword(0, 0);
        }

        static void FindPassword(int index, int indexByChar)
        {
            
            




        }
    }
}
