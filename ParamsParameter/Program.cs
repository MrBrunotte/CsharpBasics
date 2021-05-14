using System;

namespace ParamsParameter
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //ParamsMethod();
            //ParamsMethod(Numbers);
            ParamsMethod(1, 2, 3, 4, 5);
        }
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine($"There are {Numbers.Length} elements in the array");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();
        }
    }
}
