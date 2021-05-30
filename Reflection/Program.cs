using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        private static void Main()
        {
            Customer C1 = new Customer();

            //Type T = Type.GetType("Reflection.Customer");
            Type T = typeof(Customer);

            Console.WriteLine($"Full name of Type: {T.FullName}");
            Console.WriteLine($"Class name of Type: {T.Name}");
            Console.WriteLine($"Namespace name of Type: {T.Namespace}\n");

            Console.WriteLine("Properties in the Customer Class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            }

            Console.WriteLine("\nMethods in the Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
            }

            Console.WriteLine("\nConstructors in the Customer Class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine($"{constructor.ToString()}");
            }
        }
    }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Customer(int _id, string _name)
            {
                ID = _id;
                Name = _name;
            }
            public Customer()
            {
                ID = 5;
                Name = string.Empty;
            }
            public void PrintID()
            {
                Console.WriteLine($"ID = {ID}");
            }
            public void PrintName()
            {
                Console.WriteLine($"Name = {Name}");
            }
        }
}
