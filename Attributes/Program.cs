using System;
using System.Collections.Generic;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            // remove the comment to see that its an error
            //Calculator.Add(10, 20);
            Calculator.Add(10, 20, 30);
            Calculator.Add(new List<int>() { 10, 20, 30 });
        }
        public class Calculator
        {
            [Obsolete("Use the method: Add(List<int> Numbers)", true)]
            public static int Add(int firstNumber, 
                                  int secondNumber)
            {
                return firstNumber + secondNumber;
            }
            [Obsolete]
            public static int Add(int firstNumber, 
                                  int secondNumber, 
                                  int thirdNumber)
            {
                return firstNumber + secondNumber + thirdNumber;
            }
            public static int Add(List<int> Numbers)
            {
                int Sum = 0;
                foreach (int number in Numbers)
                {
                    Sum = Sum + number;
                } 
                return Sum;
            }
        }
    }
}
