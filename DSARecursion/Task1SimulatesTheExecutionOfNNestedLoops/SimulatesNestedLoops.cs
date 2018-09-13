using System;

namespace Task1SimulatesTheExecutionOfNNestedLoops
{
    class SimulatesNestedLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NestedLoop(n, 0, "");
        }
        public static void NestedLoop(int n, int loopsCount, string currNumber)
        {
            if (n == loopsCount)
            {
                Console.WriteLine(currNumber);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                NestedLoop(n, loopsCount + 1, currNumber + i.ToString());
            }
        }
    }
}
