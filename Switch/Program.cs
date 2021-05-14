using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeCost = 0;
 
            Console.WriteLine("What size of coffee would you like?");
            Console.WriteLine("1 - small, 2 - medium or 3 - large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeCost += 1;
                    Console.WriteLine("You ordered a small coffee, that will be $5");
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    Console.WriteLine("You ordered a small coffee, that will be $8");
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    Console.WriteLine("You ordered a small coffee, that will be $12");
                    break;
                default:
                    Console.WriteLine($"Your choice {UserChoice} is invalid!");
                    break;
            }
            Console.WriteLine("Thank you for shopping with us!");
        }
    }
}
