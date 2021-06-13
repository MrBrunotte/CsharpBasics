using System;
using System.Collections.Generic;

namespace _82_GenericQueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer objects
            Customer customer1 = new Customer() { ID = 101, Name = "Mark", Gender = "Male" };
            Customer customer2 = new Customer() { ID = 102, Name = "Pam", Gender = "Female" };
            Customer customer3 = new Customer() { ID = 103, Name = "Rob", Gender = "Male" };
            Customer customer4 = new Customer() { ID = 104, Name = "Valerie", Gender = "Female" };
            Customer customer5 = new Customer() { ID = 105, Name = "Ken", Gender = "Male" };

            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            Console.WriteLine($"Total items in queue: {queueCustomers.Count}");

            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine($"Dequeue item: {c1.ID} - {c1.Name}");
            Console.WriteLine($"Total items in queue: {queueCustomers.Count}\n");

            Console.WriteLine("Queueing Customers");
            foreach (Customer c in queueCustomers)
            {
                Console.WriteLine($"{c.ID} - {c.Name}");
                Console.WriteLine($"Total items in queue: {queueCustomers.Count}");
            }

            // Peek at the first customer
            Customer customerPeek = queueCustomers.Peek();
            Console.WriteLine($"\nLets peek who the first customer is: {customerPeek.Name}");
            Console.WriteLine($"Total items in queue: {queueCustomers.Count}\n");

            //Contains method
            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine($"Customer 1 exists");
            }
            else
                Console.WriteLine($"Customer 1 does not exist");
            //Contains method
            if (queueCustomers.Contains(customer2))
            {
                Console.WriteLine($"Customer 1 exists");
            }
            else
                Console.WriteLine($"Customer 2 does not exist");

        }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
    }
}
