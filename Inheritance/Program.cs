using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Stefan";
            FTE.LastName = "Brunotte";
            FTE.Email = "sb@sb.com";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();
            
        }
    }
    public class Employee
    {
        // fields default is private
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            //instance method
            Console.WriteLine($"Firstname: {FirstName}\nLastName: {LastName}\nEmail: {Email}");
        }
    }
    public class FullTimeEmployee : Employee
    {
        // Everything in the Employee class (base class) 
        // will be accessible here!
        public float YearlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        // Everything in the Employee class (base class) 
        // will be accessible here!
        public float HourlyRate;
    }

}
