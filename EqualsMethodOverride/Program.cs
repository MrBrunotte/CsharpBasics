using System;

namespace EqualsMethodOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("Comparison with Equals() method");
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
            // System.Object

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine("\nEnum comparison with Equals() method");
            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Console.WriteLine("\nClass comparison with Reference types");
            Customer C1 = new Customer();
            C1.FirstName = "Stefan";
            C1.LastName = "Brunotte";

            Customer C2 = new Customer();
            C2.FirstName = "Stefan";
            C2.LastName = "Brunotte";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return FirstName == ((Customer)obj).FirstName && 
                   LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        South = 3,
        North = 4
    }
}
