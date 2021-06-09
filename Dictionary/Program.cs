using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Stefan", Salary = 5000 };
            Customer customer2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer customer3 = new Customer() { ID = 119, Name = "John", Salary = 7000 };

            // Create Dictionary of the Customer objects
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            // Check if key exists
            if (!dictionaryCustomers.ContainsKey(customer3.ID))
            {
                dictionaryCustomers.Add(customer1.ID, customer3);
            }

            // Create Customer object from key 119 from our dictionary list
            // and print values
            Customer customer119 = dictionaryCustomers[119];
            Console.WriteLine($"ID: {customer119.ID}" +
                              $"\nName: {customer119.Name}" +
                              $"\nSalary: {customer119.Salary}\n");

            // Print out key and values for each Customer object in the list
            // We can also use the implicit var variable insted of KeyValuePair
            foreach (KeyValuePair<int,Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine($"\nPrint the Key (ID) value:\n\tKey = {customerKeyValuePair.Key}");
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine($"Print the values:\n\tID: {cust.ID}" +
                                  $"\n\tName: {cust.Name}\n\t" +
                                  $"Salary: {cust.Salary}n");
                Console.WriteLine("------------------------------");
            }
            // print out all the keys
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine($"Key: {key}\n" +
                                  $"------------------------------");
            }
            // print out all the values
            foreach (Customer cust in dictionaryCustomers.Values)
            {
                Console.WriteLine($"Print the values:\n\tID: {cust.ID}" +
                                  $"\n\tName: {cust.Name}\n\t" +
                                  $"Salary: {cust.Salary}n");
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
