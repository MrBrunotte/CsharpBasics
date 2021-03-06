using System;
using System.Runtime.InteropServices;

namespace OptionalParametersOptionalAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[] { 30, 40, 50, 60 } );
        }
        public static void AddNumbers(int firstNumber,
                                      int secondNumber,
                                      [Optional] int[]restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"sum: {result.ToString()}");
            Console.ReadKey();
        }
    }
}
