using System;

namespace PublicAccessors
{
    public class Customer
    {
        protected int ID;
        protected string Name;
    }
    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            
            // Derived class object
            CC.ID = 101;
            // base
            base.Name = "Stefan";
            // this
            this.Name = "Viggo";
            // or just the protected string
            Name = "Johanna";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // the _id is an instance field
            Customer C1 = new Customer();
            //Console.WriteLine(C1.Name);
            //base.Name;
            //this.Name;
            //Name;

        }
    }
}
