using System;

namespace OptionalParametersArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20);
            AddNumbers(30, 40, 50);

            AddNumbers(10, 20, new object[] { 30, 40, 50 });
        }
        public static void AddNumbers(int firstNumber, 
                                      int secondNumber, 
                                      params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"sum: {result}");
            Console.ReadKey();
        }
    }
}
