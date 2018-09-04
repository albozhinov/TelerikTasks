using System;
using System.Collections.Generic;
using System.Linq;

namespace Solve_
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var sum = 0;

            if (!inputLine.Contains('('))
            {
                sum = CalcSum(inputLine);
            }
            else
            {
                var brackets = new Stack<int>();

                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (inputLine[i] == '(')
                    {
                        brackets.Push(i);
                    }
                    else if (inputLine[i] == ')')
                    {
                        var start = brackets.Pop() + 1;
                        var end = i;
                        var subString = inputLine.Substring(start, end - start);

                        if (subString.Contains('+'))
                        {
                            var nums = subString.Split('+');
                            for (int k = 0; k < nums.Length; k++)
                            {
                                var isParsed = int.TryParse(nums[k], out int parsedNum);
                                if (isParsed)
                                {
                                    sum += parsedNum;
                                }
                            }
                        }
                        if (subString.Contains('-'))
                        {
                            var nums = subString.Split('-');
                            var currSum = 0;
                            var firt = true;
                            for (int k = 0; k < nums.Length; k++)
                            {                                
                                var isParsed = int.TryParse(nums[k], out int parsedNum);
                                if (isParsed && firt)
                                {
                                    currSum = parsedNum;
                                    firt = false;
                                }
                                else if(isParsed)
                                {
                                    currSum -= parsedNum;
                                }
                            }
                            sum += currSum;
                        }

                    }


                }



            }

            Console.WriteLine(sum);
        }
        
        public static int CalcSum(string text)
        {           
            if (text.Contains('+'))
            {
                var numbers = text.Split('+').ToList();
                var sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    var isParsed = int.TryParse(numbers[i], out int parsedNum);
                    if (isParsed)
                    {
                        sum += parsedNum;
                    }
                }
                return sum;
            }
            else if (text.Contains('-'))
            {
                var numbers = text.Split('-').ToList();
                var sum = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    var isParsed = int.TryParse(numbers[i], out int parsedNum);
                    if (isParsed)
                    {
                        sum += parsedNum;
                    }
                }
                return sum;

            }
            else if (text.Contains('*'))
            {
                var numbers = text.Split('+').ToList();
                var sum = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    var isParsed = int.TryParse(numbers[i], out int parsedNum);
                    if (isParsed)
                    {
                        sum += parsedNum;
                    }
                }
                return sum;
            }
            return 0;
        }
    }
}
