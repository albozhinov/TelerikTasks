using System;

namespace Dadadasdada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                       

            int maxPrime = 1;
            for (int i = 3; i <= Math.Sqrt(n); i++)
            {
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (Math.Sqrt(i) %  k == 0)
                    {
                        break;
                    }
                    else
                    {

                    }
                }


            }
            Console.WriteLine(maxPrime);
        }
    }
}
