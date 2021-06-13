using System;
using System.Collections.Generic;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "RetailCustomer" };
            Customer customer2 = new Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "RetailCustomer" };
            Customer customer3 = new Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "RetailCustomer" };
            Customer customer4 = new Customer() { ID = 104, Name = "John", Salary = 6500, Type = "CorporateCustomer" };
            Customer customer5 = new Customer() { ID = 102, Name = "Sam", Salary = 3500, Type = "CorporateCustomer" };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            Console.WriteLine("Before AddRange() method");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }
            Console.WriteLine($"Number of objects in the list: {listCustomers.Count}\n");

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.AddRange(listCorporateCustomers);
            Console.WriteLine("After AddRange() method");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }
            Console.WriteLine($"Number of objects in the list: {listCustomers.Count}\n");

            //GetRange();
            Console.WriteLine("GetRange() method");
            Console.WriteLine("Get range from index 3 and count 2");
            foreach (Customer customer in listCustomers.GetRange(3,2))
            {
                Console.WriteLine(customer.Type);
            }

            Console.WriteLine("---------------\n");
            //InsertRange()
            listCustomers.InsertRange(1, listCorporateCustomers);
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }

            //RemoveRange
            Console.WriteLine("\n------- RemoveRange() Before -------");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }
            listCustomers.RemoveRange(0,2);
            Console.WriteLine("\n------- RemoveRange() After -------");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }
            //RemoveAll
            Console.WriteLine("\n------- RemoveAll() CorporateCustomer -------");
            listCustomers.RemoveAll(removeAll => removeAll.Type == "CorporateCustomer");
            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine(customer.Type);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
