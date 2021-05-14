using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            ICustomer1 Cust = new Customer();
            Console.WriteLine("\nCust only has access to Print1() " +
                              "since it is of type ICustomer1");
            Cust.Print1();

            Console.ReadKey();
        }
    }

    interface ICustomer1
    {
        void Print1();
    }
    interface ICustomer2: ICustomer1
    {
        void Print2();
    }
   class Customer : ICustomer2   
    {
        // Customer must implement both Interface method
        public void Print1()
        {
            Console.WriteLine("ICustomer1 print method");
        }
        public void Print2()
        {
            Console.WriteLine("ICustomer2 print method");
        }
    }
}
