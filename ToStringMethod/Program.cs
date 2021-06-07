using System;


namespace ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Stefan";
            C1.LastName = "Brunotte";
            C1.ID = 101;

            Console.WriteLine(C1.ToString());
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"\nFull name: {FirstName} {LastName}\nID: {ID}";
        }
    }
}
