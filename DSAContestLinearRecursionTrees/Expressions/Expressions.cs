using System;
using System.Text;

namespace Expressions
{
    class Expressions
    {
        static string firstNumber;
        static string secNumber;
        static int counter = 0;

        static void Main(string[] args)
        {
            firstNumber = Console.ReadLine();
            secNumber = Console.ReadLine();
            long num = long.Parse(firstNumber);           
            
            long endNum = 0;
            long previous = long.Parse(firstNumber[0].ToString());

            Solve(1, previous, endNum);
            
            int index = 1;

            while (index != firstNumber.Length)
            {
                if (firstNumber.Contains("0"))
                {
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    previous = long.Parse(firstNumber.Substring(0, index));
                    num = long.Parse(firstNumber.Substring(index, firstNumber.Length - index));

                    if (i == 0)
                    {                        
                        previous += num;
                    }
                    else if (i == 1)
                    {                        
                        previous -= num;
                    }
                    else if (i == 2)
                    {                                          
                        previous *= num;
                    }
                    if (previous.ToString() == secNumber)
                    {
                        counter++;
                    }
                }
                index++;
            }            

            if (firstNumber == secNumber)
            {
                counter++;
            }

            Console.WriteLine(counter);
        }

        static void Solve(int index, long previous, long num)
        {
            if (firstNumber.Length == index)
            {                
                if (previous.ToString() == secNumber)
                {
                    counter++;
                }
                return;
            }
            
            for (int i = 0; i < 3; i++)
            {                
                num = long.Parse(firstNumber[index].ToString());                

                if (i == 0)
                {                    
                    Solve(index + 1, previous + num, num);                    
                }
                else if (i == 1)
                {                    
                    Solve(index + 1, previous - num, num);                    
                }
                else if (i == 2)
                {
                    if (previous != 0 && num == 0)
                    {
                        continue;
                    }
                    if (index - 1 > 0)
                    {
                        long num1 = long.Parse(firstNumber[index - 1].ToString());
                        if (previous >= 0)
                        {
                            previous -= num1;
                            Solve(index + 1, previous + num1 * num, num);
                            previous += num1;
                        }
                        else
                        {
                            previous += num1;
                            Solve(index + 1, previous + num1 * num, num);
                            previous -= num1;
                        }
                    }
                    else
                    {
                        Solve(index + 1, previous * num, num);   
                        
                    }                   
                }
            }
        }       
    }
}
