namespace JustPopcorn
{
    using System;
    using System.Threading;

    class Popcorn
    {
        static int ballX;
        static int ballY;

        static int[] horizontalDirection;
        static int[] verticalDirection;
        static int currentDirectionX;
        static int currentDirectionY;

        static int padX;
        static readonly int padY = Console.WindowHeight - 1;
        static int padLenght;

        static int[,] fieldOfBricks;

        static void InitilaBricks()
        {
            for (int i = 5 ; i < 15; i++)
            {
                for (int j = 5; j < Console.WindowWidth - 5; j++)
                {
                    fieldOfBricks[j, i] = 1;
                }
            }
        }

        static void RenderBricks()
        {
            for (int i = 0; i < fieldOfBricks.GetLength(0); i++)
            {
                for (int j = 0; j < fieldOfBricks.GetLength(1); j++)
                {
                    if (fieldOfBricks[i,j] != 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('*');
                    }
                }
            }
        }

        static void Setting()
        {
            Console.Title = "Popcorn";
            Console.SetWindowSize(59, 39);
            Console.SetBufferSize(60, 40);
            Console.CursorVisible = false;
            ballX = Console.WindowWidth / 2;
            ballY = Console.WindowHeight / 2;
            currentDirectionX = 0;
            currentDirectionY = 0;
            horizontalDirection = new int[2] { -1, 1 }; // Добра практика е да се сетват тук стойностите на тези променливи,
            verticalDirection = new int[2] { -1, 1 };  // а не горе при инициализирането на полетата !!!
            padX = Console.WindowWidth / 2 - 4;            
            padLenght = 9;
            fieldOfBricks = new int[Console.WindowWidth + 1, Console.WindowHeight + 1];

        }

        static void MovePad()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                while (Console.KeyAvailable)
                {                    
                    Console.ReadKey();
                }
                ExecuteKey(key);
            }
        }

        static void ExecuteKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (padX > 0)
                {
                    padX--;
                    Console.SetCursorPosition(padX + padLenght, padY);
                    Console.Write(' ');
                    RenderPad();
                }                
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (padX + padLenght < Console.WindowWidth)
                {
                    padX++;
                    Console.SetCursorPosition(padX - 1, padY);
                    Console.Write(' ');
                    RenderPad();
                }
            }                
        }

        static void RenderPad()
        {
            for (int i = padX; i < padX + padLenght; i++)
            {
                Console.SetCursorPosition(i, padY);
                Console.Write('#');
            }
        }
        
        static void MoveBall()
        {
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(' ');
            ballX += horizontalDirection[currentDirectionX];
            ballY += verticalDirection[currentDirectionY];
            Console.SetCursorPosition(ballX, ballY);
            Console.Write('@');
        }

        static void CollisionWithWall()
        {
            if (ballX <= 0)
            {
                ChangeXDirection();
            }
            if (ballX >= Console.WindowWidth - 1)
            {
                ChangeXDirection();
            }
            if (ballY <= 1)
            {
                ChangeYDirection();
            }
            if (ballY >= Console.WindowHeight - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }

        static void CollisionWithPad()
        {
            if (ballY + 1 == padY && ballX >= padX - 1 && ballX <= padX + padLenght + 1)
            {
                ChangeYDirection();
            }
        }

        static void CollisionWithBricks()
        {
            if (ballY - 1 >= 0 && fieldOfBricks[ballX, ballY - 1] == 1)
            {
                fieldOfBricks[ballX, ballY - 1] = 0;
                Console.SetCursorPosition(ballX, ballY - 1);
                Console.Write(' ');
                ChangeYDirection();
            }
            if (ballY + 1 < Console.WindowHeight - 2 && fieldOfBricks[ballX, ballY + 1] == 1)
            {
                fieldOfBricks[ballX, ballY + 1] = 0;
                Console.SetCursorPosition(ballX, ballY + 1);
                Console.Write(' ');
                ChangeYDirection();
            }
            if (ballX + 1 < Console.WindowWidth - 2 && fieldOfBricks[ballX + 1, ballY] == 1)
            {
                fieldOfBricks[ballX + 1, ballY] = 0;
                Console.SetCursorPosition(ballX + 1, ballY);
                Console.Write(' ');
                ChangeXDirection();
            }
            if (ballX - 1 >= 0 && fieldOfBricks[ballX - 1, ballY] == 1)
            {
                fieldOfBricks[ballX - 1, ballY] = 0;
                Console.SetCursorPosition(ballX - 1, ballY);
                Console.Write(' ');
                ChangeXDirection();
            }
        }

        static void ChangeXDirection()
        {
            if (currentDirectionX == 0)
            {
                currentDirectionX = 1;
            }
            else
            {
                currentDirectionX = 0;
            }
        }

        static void ChangeYDirection()
        {
            if (currentDirectionY == 0)
            {
                currentDirectionY = 1;
            }
            else
            {
                currentDirectionY = 0;
            }
        }

        static void Engine()
        {
            InitilaBricks();
            RenderBricks();
            RenderPad();
            int speed = 0;

            while (true)
            {                
                if (speed % 2 == 0)
                {
                    try
                    {
                        CollisionWithWall();

                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2);
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        break;
                    }
                    CollisionWithPad();
                    CollisionWithBricks();
                    MoveBall();
                }
                MovePad();                
                Thread.Sleep(100);
                speed++;

                if (speed > 100)
                {
                    speed = 0;
                }
            }
        }

        static void Main()
        {
            Setting();
            Engine();
        }
    }
}
