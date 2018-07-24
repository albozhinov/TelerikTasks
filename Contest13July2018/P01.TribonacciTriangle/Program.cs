using System;
using System.Collections.Generic;
using System.Text;

namespace P01.TribonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long T1 = int.Parse(Console.ReadLine());
            long T2 = int.Parse(Console.ReadLine());
            long T3 = int.Parse(Console.ReadLine());

            int L = int.Parse(Console.ReadLine());

            List<long> tribonacciNumbers = new List<long>();
            tribonacciNumbers.Add(T1);
            tribonacciNumbers.Add(T2);
            tribonacciNumbers.Add(T3);

            // Print Tribonacci numbers!            
            int index = 0;
            string printNums = "";
            for (int row = 1; row <= L; row++)
            {
                printNums = "";
                for (int col = 0; col < row; col++)
                {                    
                    if (index >= tribonacciNumbers.Count)
                    {
                        long Tn = T1 + T2 + T3;
                        tribonacciNumbers.Add(Tn);
                        T1 = T2;
                        T2 = T3;
                        T3 = Tn;
                    }
                    printNums += $"{tribonacciNumbers[index]} ";
                    index++;
                }
                printNums = printNums.TrimEnd(' ');
                Console.WriteLine(printNums);
            }            
        }
    }
}
