using System;

namespace StructVSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types int i and int j
            Console.WriteLine("Value types");
            int i = 10;
            int j = i;
            j = j + 1;

            Console.WriteLine($"i = {i} and j = {j}");


            // Reference types C1 an C2
            Console.WriteLine("\nReference types");
            Customer C1 = new Customer();
            C1.ID = 101;
            C1.Name = "Stefan";
            Console.WriteLine($"C1.Name = {C1.Name}");

            Customer C2 = C1;
            C2.Name = "Mary";

            Console.WriteLine($"C1.Name = {C1.Name} and C2.Name = {C2.Name}");
            Console.WriteLine($"C1.Name = 'Stefan' has changed to {C1.Name}!");


            Console.ReadKey();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
