using System;

namespace OutParameter
{
    class Program
    {
        public static void Main()
        {
            int Total = 0;
            int Product = 0;

            Calculate(10, 20, out Total, out Product);

            Console.WriteLine($"Sum = {Total} && Product = {Product}");
        }

        public static void Calculate(int firstNum, int secondNum, out int Sum, out int Product)
        {
            Sum = firstNum + secondNum;
            Product = firstNum * secondNum;
        }


    }
}
