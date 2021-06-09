using System;
using System.Collections.Generic;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "customer1", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "customer2", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "customer3", Salary = 7000 };

            // Create Customer array with 2 objects
            Customer[] customers = new Customer[2];
            customers[0] = customer1;
            customers[1] = customer2;
            //customers[2] = customer3;

            // Create a list of Customer type
            List<Customer> customersList = new List<Customer>(2);
            customersList.Add(customer1);
            customersList.Add(customer2);
            customersList.Add(customer3);
            // Retrieve name of first customer in the zero based index list
            Customer C = customersList[0];
            Console.WriteLine($"Customer name at index 0: {C.Name}");
            Console.WriteLine("------------- foreach loop -------------------");
            // iterate through the list with foreach loop
            foreach (Customer customer in customersList)
            {
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }
            Console.WriteLine("------------- for loop -------------------");
            // iterate through the list with for loop
            for (int i = 0; i < customersList.Count; i++)
            {
                Customer customer = customersList[i];
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }
            // create an instance of the inheriting SavingsCustomer class
            SavingCustomer sc = new SavingCustomer() { ID = 200, Name = "customerCS", Salary = 9000 };
            customersList.Add(sc);

            // insert at specific position in the list
            customersList.Insert(0, customer3);
            Console.WriteLine("------------- foreach loop after insert -------------------");
            // iterate through the list with foreach loop
            foreach (Customer customer in customersList)
            {
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }
            Console.WriteLine("------------- Index of function -------------------");
            Console.WriteLine($"Index of parameter less overload: {customersList.IndexOf(customer3)}");
            Console.WriteLine($"Index of parameter less overload: {customersList.IndexOf(customer3, 1)}");
            Console.WriteLine($"Index of parameter less overload: {customersList.IndexOf(customer3, 1, 2)}");
            Console.WriteLine($"Index of parameter less overload: {customersList.IndexOf(customer3, 1, 3)}");
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class SavingCustomer : Customer
    {

    }
}
