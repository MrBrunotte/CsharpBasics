using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TempTimeEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }

            Console.ReadKey();
        }
    }

    public class Employee
    {
        // fields default is private
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            //instance method
            Console.WriteLine($"\tFirstname: {FirstName} LastName: {LastName}");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            //instance method
            Console.WriteLine($"\tFirstname: {FirstName} LastName: {LastName} - Part Time");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class TempTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            //instance method
            Console.WriteLine($"\tFirstname: {FirstName} LastName: {LastName} -Temporary");
        }
    }
}
