using System;

namespace ExceptionHandlingAbuseHowToDoInstead
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (IsNumeratorConversionSuccessfull)
                {
                    Console.WriteLine("Please enter a Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (IsDenominatorConversionSuccessfull && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine($"Result = {Result}");
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine($"Denominator cannot be zero!");
                        }
                        else
                        {
                            Console.WriteLine($"Denominator should be a valid number between {int.MinValue} and {int.MaxValue} ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Numerator should be a valid number between {int.MinValue} and {int.MaxValue} ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
