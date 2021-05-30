using PublicAccessorsInternal_ProtectedClassLibrary;
using System;

namespace PublicAccessorsInternalProtected
{
    class PubAccIntProClassTwo : PubAccIntProClass
    {
        public void Print()
        {
            PubAccIntProClass instance2 = new PubAccIntProClass();
            base.ID = 101;

            PubAccIntProClassTwo instance3 = new PubAccIntProClassTwo();
            instance3.ID = 104;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
