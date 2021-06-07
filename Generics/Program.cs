using System;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            bool EqualStrings = Calculator<string>.AreEqual("A", "A");
            Console.WriteLine("Comparing strings:");
            if (EqualStrings)
            {
            Console.WriteLine("Equal");
            }
            else
            {
            Console.WriteLine("Not equal");
            }

            Console.WriteLine("\nComparing ints:");
            bool EqualNumbers = Calculator<int>.AreEqual(10, 20);
            if (EqualNumbers)
            {
                Console.WriteLine("Equal");
            }
            else
            {
            Console.WriteLine("Not equal");
            }
        }
        public class Calculator<T>
        {
            public static bool AreEqual(T _value1, T _value2)
            {
                return _value1.Equals(_value2);
            }
        }
    }
}
