using System;
using System.Linq;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            var positionInfo = Console.ReadLine().ToCharArray();

            var path = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool[] isVisited = new bool[positionInfo.Length];

            int codersSoul = 0;
            int food = 0;
            int deadlock = 0;
            int currPosition = 0;
            int jumpsCOunt = -1;

            for (int i = 0; i <= path.Length; i++)
            {
                jumpsCOunt++;
                if (positionInfo[currPosition] == '@' && !isVisited[currPosition])
                {
                    codersSoul++;
                    isVisited[currPosition] = true;
                }
                else if (positionInfo[currPosition] == '*' && !isVisited[currPosition])
                {
                    food++;
                    isVisited[currPosition] = true;
                }
                else if (positionInfo[currPosition] == 'x' && !isVisited[currPosition])
                {
                    deadlock++;
                    isVisited[currPosition] = true;
                    if (currPosition % 2 == 0)
                    {
                        if (codersSoul == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine($"Jumps before deadlock: {jumpsCOunt}");
                            Environment.Exit(0);
                        }
                        codersSoul--;
                        positionInfo[currPosition] = '@';
                        isVisited[currPosition] = false;
                    }
                    else if (currPosition % 2 == 1)
                    {
                        if (food == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine($"Jumps before deadlock: {jumpsCOunt}");
                            Environment.Exit(0);
                        }
                        food--;
                        positionInfo[currPosition] = '*';
                        isVisited[currPosition] = false;
                    }
                }
                if (i < path.Length && path[i] > 0)
                {
                    currPosition = FindPosition(path[i], currPosition, positionInfo.Length);
                }
                else if (i < path.Length)
                {
                    currPosition = FindPosition(path[i], currPosition, positionInfo.Length);
                }               
            }
            Console.WriteLine($"Coder souls collected: {codersSoul}");
            Console.WriteLine($"Food collected: {food}");
            Console.WriteLine($"Deadlocks: {deadlock}");
        }

        public static int FindPosition(int step, int currPosition, int length)
        {
            int position = 0;
            position = (currPosition + step) % length;

            if (position < 0)
            {
                position += length;
            }
            return position;
        }
    }
}
