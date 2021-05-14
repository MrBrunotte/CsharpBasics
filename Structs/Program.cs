using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the second constructor to initialize C1
            Customer C1 = new Customer(101, "Stefan");
            C1.PrintDetails();

            // Using the default constructor to initialize C2
            Customer C2 = new Customer();
            C2.ID = 102;
            C2.Name = "Peter";
            C2.PrintDetails2();

            // Initializer and tags
            Customer C3 = new Customer
            {
                ID = 103,
                Name = "Julia"
            };
            C3.PrintDetails3();

            Console.ReadKey();
        }
    }
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Using the default constructor\nId = {ID} and Name = {Name}\n");
        }
        public void PrintDetails2()
        {
            Console.WriteLine($"Using the parameterized constructor\nId = {ID} and Name = {Name}\n");
        }
        public void PrintDetails3()
        {
            Console.WriteLine($"Using the object initializer and tags\nId = {ID} and Name = {Name}");
        }
    }
}
