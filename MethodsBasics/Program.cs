using System;

namespace MethodsBasics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n--------------------------\n");
            // static method is called in the Program class
            // We can omit Program. from the call!
            Program.EvenNumbers(30);


            Console.WriteLine("\n--------------------------\n");
            // to invoke the Add() we need an instance of Program
            Program p = new Program();
            int sum = p.Add(10, 20);
            Console.WriteLine($"The sum is {sum}");
        }


        // instance class!!
        public int Add(int firstNum, int secondNum)
        {

            return firstNum + secondNum;
        }

        public static void EvenNumbers(int target)
        {
            int Start = 0;
            Console.WriteLine("Print even numbers from 0-20");
            while (Start <= target)
            {
                Console.Write($"{Start}, " );
                Start = Start + 2;
            }
        }
    }
}

