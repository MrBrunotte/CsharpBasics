using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();
            
            Employee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();
        }
    }
    public class Employee
    {
        // fields default is private
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            //instance method
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            // instance method
            Console.WriteLine($"{FirstName} {LastName} - Contractor");

            // invoke the base class method
            // base.PrintFullName();

            Console.ReadKey();
        }
    }
    public class FullTimeEmployee : Employee
    {

    }
}
