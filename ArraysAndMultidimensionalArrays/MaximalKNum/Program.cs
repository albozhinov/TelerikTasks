using System;

namespace MaximalKNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);

            int result = 0;
            for (int i = N - 1; i >= N - K; i--)
            {
                result += arr[i];
            }
            Console.WriteLine(result);
        }
    }
}
