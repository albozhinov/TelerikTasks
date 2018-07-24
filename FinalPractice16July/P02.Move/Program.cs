using System;
using System.Linq;
using System.Numerics;

namespace P02.Move
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPosition = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            BigInteger forwardSum = 0;
            BigInteger backwardSum = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "exit")
                {
                    break;
                }
                var commands = inputLine.Split(' ').ToArray();
                int countOfMove = int.Parse(commands[0]);
                string direction = commands[1];
                int size = int.Parse(commands[2]);


                if (direction == "forward")
                {
                    for (int i = 0; i < countOfMove; i++)
                    {                
                        startPosition = FindPositio(startPosition, size, numbers.Length);                        
                        
                        forwardSum += numbers[startPosition];
                    }
                }
                else
                {
                    for (int i = 0; i < countOfMove; i++)
                    {
                        startPosition = FindPositio(startPosition, -size, numbers.Length);
                        
                        backwardSum += numbers[startPosition];
                    }

                }
            }
            Console.WriteLine($"Forward: {forwardSum}");
            Console.WriteLine($"Backwards: {backwardSum}");       
                
        }

        private static int FindPositio(int currPostion, int size, int lenght)
        {
            int position = 0;
            position = (currPostion + size) % lenght;
            if (position < 0)
            {
                position += lenght;
            }
            return position;
        }
    }
}

