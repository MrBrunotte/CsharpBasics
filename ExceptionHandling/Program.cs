using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\brunoste\OneDrive - Prog-It Oy\Skrivbordet\Sample");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
    }
}
