using System;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int sum = 0;
            int maxSum  = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());                
            }
            
            for (int i = 1; i < N - 1; i++)
            {
                sum = numbers[i] + numbers[i - 1];

                for (int k = i + 1; k < N; k++)
                {
                    sum += numbers[k];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }                    
                }              
            }
            Console.WriteLine(maxSum);
        }
    }
}
