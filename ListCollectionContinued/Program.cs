using System;
using System.Collections.Generic;
using System.Linq;

namespace ListCollectionContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "customer1", Salary = 4000 };
            Customer customer2 = new Customer() { ID = 110, Name = "customer2", Salary = 7000 };
            Customer customer3 = new Customer() { ID = 119, Name = "customer3", Salary = 5500 };
            // Create a list of Customer type
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            // Contains() function - return type boolean
            Console.WriteLine("------ Contains() function ------");
            if (listCustomers.Contains(customer3))
                Console.WriteLine($"{customer3.Name} exists in the list");
            else
                Console.WriteLine($"{customer3.Name} does not exists in the list");

            // Exists() function - return type boolean
            Console.WriteLine("\n------ Exists() function ------");
            if (listCustomers.Exists(cust => cust.Name.EndsWith("6")))
                Console.WriteLine($"{customer3.Name} ends with 3");
            else
                Console.WriteLine($"No Customer name with this ending!");

            // Find() function - return type Customer object
            Console.WriteLine("\n------ Find() function ------");
            Customer c = listCustomers.Find(cust => cust.Salary > 5000);
            Console.WriteLine($"Id: {c.ID}, Name: {c.Name}, Salary: {c.Salary}");

            // FindLast() function - return type Customer object
            Console.WriteLine("\n------ FindLast() function ------");
            Customer cLast = listCustomers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine($"Id: {cLast.ID}, Name: {cLast.Name}, Salary: {cLast.Salary}");

            // FindAll() function - return type List
            Console.WriteLine("\n------ FindAll() function ------");
            List<Customer> cAll = listCustomers.FindAll(cust => cust.Salary > 5000);
            foreach (Customer customer in cAll)
            {
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }

            // FindIndex() function - return type List
            Console.WriteLine("\n------ FindIndex() function ------");
            int index = listCustomers.FindIndex(cust => cust.Salary > 5000);
            Console.WriteLine($"Index = {index}");
            int indexSt2 = listCustomers.FindIndex(2, cust => cust.Salary > 5000);
            Console.WriteLine($"Index = {indexSt2}");

            // FindLastIndex() function - return type List
            Console.WriteLine("\n------ FindLastIndex() function ------");
            int indexLast = listCustomers.FindLastIndex(cust => cust.Salary > 5000);
            Console.WriteLine($"Index = {indexLast}");

            // Create a Customer Array
            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            // ToList() method - Array to list
            Console.WriteLine("\n------ ToList() method ------");
            List<Customer> listArrayCustomers = customerArray.ToList();
            foreach (Customer customer in listArrayCustomers)
            {
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }

            // ToArray() method - List to Array
            Console.WriteLine("\n------ ToArray() method ------");
            // Use the Customer list from above listCustomers
            Customer[] toArray = listCustomers.ToArray();
            foreach (Customer customer in toArray)
            {
                Console.WriteLine($"Id: {customer.ID}, Name: {customer.Name}, Salary: {customer.Salary}");
            }

            // ToDictionary() method - List to Dictionary
            Console.WriteLine("\n------ ToDictionary() method ------");
            Dictionary<int, Customer> dictinary = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Customer> kvp in dictinary)
            {
                Console.WriteLine($"Key = {kvp.Key}");
                Customer customerDict = kvp.Value;
                Console.WriteLine($"Id: {customerDict.ID}, Name: {customerDict.Name}, Salary: {customerDict.Salary}");
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
