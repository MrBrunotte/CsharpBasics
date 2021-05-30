using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"Path_goes_here");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                // here is the line where you log the details to the database or email
                Console.WriteLine($"Please check if the file: \n{ex.FileName}\nexists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                streamReader.Close();
                }
                Console.WriteLine("Finally block");
            }
        }
    }
}
