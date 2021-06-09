using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Stefan", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };

            // Create Dictionary of the Customer objects
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            // TryGetValue()
            Customer cust;
            if (dictionaryCustomers.TryGetValue(111, out cust))
            {
                Console.WriteLine($"Print the values:\n\tID: {cust.ID}" +
                                  $"\n\tName: {cust.Name}\n\t" +
                                  $"Salary: {cust.Salary}" +
                                  $"\n------------------------------");
            }
            else
                Console.WriteLine("The key is not found!" +
                                 $"\n------------------------------");

            // Count property within the Dictionary class
            Console.WriteLine($"Total items from count property: " +
                              $"{dictionaryCustomers.Count}" +
                              $"\n------------------------------");
            // System.Linq namespace Count() method
            Console.WriteLine($"Total items from Count() method: " +
                              $"{dictionaryCustomers.Count()}" +
                              $"\n------------------------------");
            // System.Linq namespace Count() method with Predicate (Linq expression)
            Console.WriteLine($"Total items from Count() overloaded method (Linq expression): " +
                              $"{dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000)}" +
                              $"\n------------------------------\n");

            // Remove() method
            dictionaryCustomers.Remove(110);
            // Clear() method
            dictionaryCustomers.Clear();

            // Convert an array into a dictionary
            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            Dictionary<int, Customer> dict = customers.ToDictionary(c => c.ID, c => c);
            Console.WriteLine("Array of Customers convertet to a dictionary");
            
            foreach (KeyValuePair<int, Customer> keyValuePair in dict)
            {
                Console.WriteLine($"Key = {keyValuePair.Key}\nValues:");
                Customer c = keyValuePair.Value;
                Console.WriteLine($"ID = {c.ID}\n" +
                                  $"Name: {c.Name}\n" +
                                  $"Salary: {c.Salary}\n");
            }
            // Convert a list into a dictionary
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);

            Dictionary<int, Customer> list = customers.ToDictionary(c => c.ID, c => c);
            Console.WriteLine("List of Customers convertet to a dictionary");

            foreach (KeyValuePair<int, Customer> keyValuePair in list)
            {
                Console.WriteLine($"Key = {keyValuePair.Key}\nValues:");
                Customer c = keyValuePair.Value;
                Console.WriteLine($"ID = {c.ID}\n" +
                                  $"Name: {c.Name}\n" +
                                  $"Salary: {c.Salary}\n");
            }
        }
    }
    public class Customer
    {
        // Auto implemented properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
