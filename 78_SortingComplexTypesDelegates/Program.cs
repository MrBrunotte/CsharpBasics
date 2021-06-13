using System;
using System.Collections.Generic;

namespace _78_SortingComplexTypesDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 78, Name = "Pam", Salary = 7000 };
            Customer customer3 = new Customer() { ID = 500, Name = "Rob", Salary = 5500 };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // Approach 1
            //Comparison<Customer> customerComparer = new Comparison<Customer>(ComparisonCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ID);
            }
            // Approach 1
            //listCustomers.Sort(customerComparer);
            // Approach 2
            //listCustomers.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
            // Approach 3
            listCustomers.Sort((c1, c2) => c1.ID.CompareTo(c2.ID));

            Console.WriteLine("\nAfter Sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.ID);
            }
            Console.ReadKey();
        }
        // Approach 1
        //private static int ComparisonCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
