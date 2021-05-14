using System;

namespace InheritancePt2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass CC = new ChildClass();
        }
    }
    public class ParentClass
    {
        // two constructors, by default the parameterless constructor
        // will be called!
        public ParentClass()
        {
            Console.WriteLine("ParentClass constructor called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ChildClass : ParentClass
    {
        // By using : base() we can choose to use the parameter constructor
        // in the parent class instead of the default constructor!
        public ChildClass() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("ChildClass constructor called");
        }
    }
}
