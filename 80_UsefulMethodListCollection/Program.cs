using System;
using System.Collections.Generic;

namespace _80_UsefulMethodListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 78, Name = "Pam", Salary = 7000 };
            Customer customer3 = new Customer() { ID = 500, Name = "Rob", Salary = 5500 };

            List<Customer> listCustomers = new List<Customer>(100);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // TrueForAll() Check if all have a salary of 5000
            Console.WriteLine("Number of objects in the list: " + listCustomers.TrueForAll(x => x.Salary == 5000));
            
            // AsReadOnly() create a read only list of listCustomers
            IReadOnlyCollection<Customer> readOnlyCustomer = listCustomers.AsReadOnly();
            Console.WriteLine($"Number of items: {readOnlyCustomer.Count}");

            // TrimAccess() We set the capacity of the list to 100
            Console.WriteLine($"\nList capacity before trimming: {listCustomers.Capacity}");
            listCustomers.TrimExcess();
            Console.WriteLine($"\nList capacity after trimming: {listCustomers.Capacity}\n");

        }


    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
