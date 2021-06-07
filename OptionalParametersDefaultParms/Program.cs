using System;

namespace OptionalParametersDefaultParms
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2);
            Test(1, 2, c: 45);
            Test(1, b: 45);
            Test(1, b: 45, 2);
        }
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine($"a = " + a);
            Console.WriteLine($"b = " + b);
            Console.WriteLine($"c = " + c);

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
