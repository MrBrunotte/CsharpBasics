using System;

namespace Interfaces2
{
    interface I1
    {
        
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    public class Program : I1, I2
    {
        // normal implementation (default)
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }
        // Explicitly implementation
        // to call this method one must type cast it!
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
        public static void Main()
        {
            Program P = new Program();
            P.InterfaceMethod();
            ((I2)P).InterfaceMethod();
        }
    }
}
