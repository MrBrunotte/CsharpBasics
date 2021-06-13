using System;
using System.Collections.Generic;

namespace _78SortingComplexTypes
{
    class Program
    {
        static void Main()
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500 };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            listCustomers.Sort();
            //listCustomers.Reverse();
            Console.WriteLine("\nAfter sorting");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Salary);
            }

            SortByName sortByName = new SortByName();
            listCustomers.Sort(sortByName);
            Console.WriteLine("\nSorting complex types with IComparer class");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.ReadKey();
        }
    }
    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    } 
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}