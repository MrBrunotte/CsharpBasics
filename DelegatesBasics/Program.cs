using System;

namespace DelegatesBasics
{
    // A delegate is a type safe function pointer
    // Delegate syntax: return type, name and parameter
    public delegate void HelloFunctionDelegate(string Message);


    class Program
    {
        static void Main(string[] args)
        {
            //createing an instance of the Program class
            //P1 is the instance of the Program class
            Program P1 = new Program();

            //creating an instance of the delegate that points to the Hello()
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");
           
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

}
