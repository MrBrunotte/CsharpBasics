using System;

namespace OverridingVsHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass B = new DerivedClass();
            B.Print();
            Console.ReadKey();
        }
    }
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Im a Base Class Print method");
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Im a Derived Class Print method");
        }
    }
}
