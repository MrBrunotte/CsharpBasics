using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            // C1 is a Customer instance/object of the Customer 
            // class that is created with the new keyword
            Customer C1 = new Customer("Stefan", "Brunotte");
            Customer C2 = new Customer();

            C1.PrintFullName();
            C2.PrintFullName();

            Console.ReadKey();
        }
    }

    class Customer
    {
        // fields represents the state, the data of this class
        string _firstName;
        string _lastName;

        // Constructor that is parameterless and referes to the second constructor.
        public Customer() : this("No first name provided", "No last name provided")
        {

        }

        // constructor with parameters that initializes the two feilds
        public Customer(string FirstName, string LastName)
        {
            _firstName = FirstName;
            this._lastName = LastName;
        }


        // adding a behavior - method
        public void PrintFullName()
        {
            Console.WriteLine($"Full name:\t {_firstName},\n" +
                              $"Last name:\t {_lastName}\n");
        }
        ~Customer()
        {
            // destructor - clean up code goes here!
        }
    }
}
