using System;
using System.Threading;

namespace _88_ThreadStartDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread Thread1 = new Thread(new ThreadStart(Number.PrintNumbers));
            Thread1.Start();
            // using the delegate keywork
            Thread Thread2 = new Thread(delegate () { Number.PrintNumbers(); });
            Thread2.Start();
            // using a lamdga expression
            Thread Thread3 = new Thread(() => Number.PrintNumbers());
            Thread3.Start();

            // invoking the non-static method
            Number numberNonStatic = new Number();
            Thread ThreadNonStatic = new Thread(new ThreadStart(numberNonStatic.PrintNumbersNotStatic));
            ThreadNonStatic.Start();
        }
    }
    class Number
    {
        //Static
        public static void PrintNumbers()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
            }
        }
        // non-static
        public void PrintNumbersNotStatic()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
            }
        }
    }
}
