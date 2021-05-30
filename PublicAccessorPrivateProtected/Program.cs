using System;

namespace PublicAccessorPrivateProtected
{
    class Program
    {
        public class BaseClass
        {
            private protected int myValue = 0;
        }
        public class DerivedClass : BaseClass
        {
            void Access()
            {
                BaseClass baseObject = new BaseClass();
                myValue = 5;
                base.myValue = 6;
                this.myValue = 7;

                //baseObject.myValue = 8;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
