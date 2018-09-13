using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Solve_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var expression = Console.ReadLine();

                BigInteger result = 0;

                var brackets = new Stack<int>();

                if (!expression.Contains('('))
                {
                    if (expression.Contains('+'))
                    {
                        var curr = expression.Split('+');
                        for (int i = 0; i < curr.Length; i++)
                        {
                            result += BigInteger.Parse(curr[i]);
                        }
                    }
                    else if (expression.Contains('-'))
                    {
                        var curr = expression.Split('-');
                        result = BigInteger.Parse(curr[0]);

                        for (int i = 1; i < curr.Length; i++)
                        {
                            result -= BigInteger.Parse(curr[i]);
                        }
                    }
                    else
                    {
                        var curr = expression.Split('*');
                        result = BigInteger.Parse(curr[0]);

                        for (int i = 1; i < curr.Length; i++)
                        {
                            result *= BigInteger.Parse(curr[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            brackets.Push(i);
                        }
                        else if (expression[i] == ')')
                        {
                            int start = brackets.Pop() + 1;
                            int end = i;
                            int lenght = end - start;
                            var currExpression = expression.Substring(start, lenght);

                            if (currExpression.IndexOf('+') + 1 == currExpression.IndexOf('('))
                            {
                                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('+')));
                                result = num + result;
                            }
                            else if (currExpression.IndexOf('-') + 1 == currExpression.IndexOf('('))
                            {
                                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('-')));
                                result = num - result;
                            }
                            else if (currExpression.IndexOf('*') + 1 == currExpression.IndexOf('('))
                            {
                                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('*')));
                                result = num * result;
                            }
                            else
                            {
                                if (currExpression.Contains('+'))
                                {
                                    var curr = currExpression.Split('+');
                                    for (int k = 0; k < curr.Length; k++)
                                    {
                                        result += BigInteger.Parse(curr[k]);
                                    }
                                }
                                else if (currExpression.Contains('-'))
                                {
                                    var curr = currExpression.Split('-');
                                    result = BigInteger.Parse(curr[0]);

                                    for (int k = 1; k < curr.Length; k++)
                                    {
                                        result -= BigInteger.Parse(curr[k]);
                                    }
                                }
                                else
                                {
                                    var curr = currExpression.Split('*');
                                    result = BigInteger.Parse(curr[0]);

                                    for (int k = 1; k < curr.Length; k++)
                                    {
                                        result *= BigInteger.Parse(curr[k]);
                                    }
                                }
                            }
                        }
                    }
                }
                result = CalcExpression(expression, result);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static BigInteger CalcExpression(string currExpression, BigInteger result)
        {            
            if (currExpression.IndexOf('+') + 1 == currExpression.IndexOf('('))
            {
                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('+')));
                result = num + result;                
            }
            else if (currExpression.IndexOf('-') + 1 == currExpression.IndexOf('('))
            {
                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('-')));
                result = num - result;                
            }
            else if (currExpression.IndexOf('*') + 1 == currExpression.IndexOf('('))
            {
                BigInteger num = BigInteger.Parse(currExpression.Substring(0, currExpression.IndexOf('*')));
                result = num * result;
            }
            return result;
        }
    }
}
