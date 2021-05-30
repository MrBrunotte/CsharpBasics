using System;
using System.IO;

namespace ExceptionInner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter a number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a second number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;
                    Console.WriteLine($"Result is: {Result}");
                }
                catch (Exception ex)
                {
                    // the filename is wronghere! should only be Log.txt
                    string filePath = @"C:\Users\brunoste\OneDrive - Prog-It Oy\Skrivbordet\Sample\Log1.txt";
                    if (File.Exists(filePath))
                    {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    Console.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a problem, please try later.");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Current Exception = {exception.GetType().Name}");
                if (exception.InnerException != null)
                {
                Console.WriteLine($"Current Exception = {exception.InnerException.GetType().Name}");
                }
            }
        }
    }
}
