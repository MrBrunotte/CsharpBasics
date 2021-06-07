using System;

namespace ConvertToStringVsToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            string str1 = C1.ToString();
            Console.WriteLine("ToString()");
            Console.WriteLine(str1);

            Customer C11 = new Customer();
            string str11 = Convert.ToString(C11);
            Console.WriteLine("\nConvert.ToString()");
            Console.WriteLine(str11);
        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}
