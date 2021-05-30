using System;
using System.Reflection;

namespace ReflectionEarlyLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("ReflectionEarlyLateBinding.Customer");
            Object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Stefan";
            parameters[1] = "Brunotte";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine($"Full name: {fullName}");


            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Stefan", "Brunotte");
            //Console.WriteLine($"My fullname is {fullName}");
        }
    }
    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
