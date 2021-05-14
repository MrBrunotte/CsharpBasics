using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(12, 45);
            Add(12, 46);
            Console.ReadKey();
        }
        public static void Add(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Sum = {sum}");
        }

        // Cannot overload a function just based on type! (int here)
        //public static int Add(int firstNum, int secondNum)
        //{
        //    int sum = firstNum + secondNum;
        //    Console.WriteLine($"Sum = {sum}");
        //    return sum;
        //}
        public static void Add(int firstNum, int secondNum, out int sum)
        {
            sum = firstNum + secondNum;
            Console.WriteLine($"Sum = {sum}");
        }
        public static void Add(int firstNum, int secondNum, int[] thirdNumber)
        {
            int sum = firstNum + secondNum;
            Console.WriteLine($"Sum = {sum}");
        }
        // cannot overload a method with the params keyword
        //public static void Add(int firstNum, int secondNum, params int[] thirdNumber)
        //{
        //    int sum = firstNum + secondNum;
        //    Console.WriteLine($"Sum = {sum}");
        //}
    }
}  

