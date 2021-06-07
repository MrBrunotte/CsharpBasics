using System;

namespace OptionalParametersOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(10, 20, 30, 40, 50);
        }
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine($"sum: {result}");
        }
        public static void AddNumbers(int firstNumber,
                                      int secondNumber,
                                      int thirdNumber,
                                      params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber + thirdNumber;
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
