using System;

namespace AbstractClass2
{
    public abstract class Customer
    {
        string fieldIsOk;
        public void Print()
        {
            Console.WriteLine("Print");
        } 
    }
    public interface ICustomer
    {
        void IPrint();
    }
    public class Program : Customer
    {
        public void IPrint()
        {
            Console.WriteLine("Prints from Interface");
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.IPrint();
            P.Print();

            Customer C = new Program();
            C.Print();
            C.IPrint();
        }
    }
}
