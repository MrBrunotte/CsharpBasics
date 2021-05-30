using System;

namespace InheritanceProblemWithMultipleInheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B implementation");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C implementation");
        }
    }
    //class D : B, C
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
           // D d = new D();
            //d.Print();

            Console.WriteLine("The Diamond problem");
            // problem: Which version of Print() method to use??
            // B or C Print() method??
        }
    }
}
