using System;

namespace AbstractClass
{
    public abstract class Customer
    {
        public abstract void Print();
    }
    public class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print method");
        }
        static void Main(string[] args)
        {
            // A program object P
            Program P = new Program();
            P.Print();

            // B Customer reference variable
            // pointing to the Program object!
            Customer C = new Program();
            C.Print();
        }
    }
}
