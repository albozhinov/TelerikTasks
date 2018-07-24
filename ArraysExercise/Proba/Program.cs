using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] firstArr = new int[size];
            int[] secArr = new int[size];
            string result = "Equal";

            for (int i = 0; i < size; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                secArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                if (firstArr[i] != secArr[i])
                {
                    result = "Not equal";
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine(result);

        }
    }
}
