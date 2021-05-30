using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter a Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;

                Console.WriteLine($"Result = {Result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Only numbers between {int.MinValue} and {int.MaxValue} are allowed!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Denominator cannot be zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
