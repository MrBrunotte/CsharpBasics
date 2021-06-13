using System;
using System.Collections.Generic;

namespace _83_GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Gender = "male" };
            Customer customer2 = new Customer() { ID = 102, Name = "Pam", Gender = "female" };
            Customer customer3 = new Customer() { ID = 103, Name = "Rob", Gender = "male" };
            Customer customer4 = new Customer() { ID = 104, Name = "Lisa", Gender = "female" };
            Customer customer5 = new Customer() { ID = 105, Name = "Stefan", Gender = "male" };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);


            Console.WriteLine($"Items left in the stack: {stackCustomers.Count}");
            Customer c1 = stackCustomers.Pop();
            Console.WriteLine($"Popped customer from top of stack: {c1.Name} with ID: {c1.ID}");
            Console.WriteLine($"Items left in the stack: {stackCustomers.Count}\n");

            foreach (Customer c in stackCustomers)
            {
                Console.WriteLine($"Popped customer from top of stack: {c.Name} with ID: {c.ID}");
                Console.WriteLine($"Items left in the stack: {stackCustomers.Count}");
            }

            Console.WriteLine($"\nItems left in the stack: {stackCustomers.Count}");
            Customer c2 = stackCustomers.Peek();
            Console.WriteLine($"Peeked customer from top of stack: {c2.Name} with ID: {c2.ID}");
            Console.WriteLine($"Items left in the stack: {stackCustomers.Count}");

            Console.WriteLine(stackCustomers.Contains(customer5));
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
