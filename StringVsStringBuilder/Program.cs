using System;
using System.Text;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" Video");
            userString.Append(" Tutorial");
            userString.Append(" For");
            userString.Append(" Beginners\n");
            Console.WriteLine(userString);

            LargeString();
        }

        // This program takes up 10 000 unnessessary string objects!
        // Because it is an unmutable string variable instead of a
        // StringBuilder object that would take only take up one
        // StringBuilder object!
        public static void LargeString()
        {
            string userString = string.Empty;
            for (int i = 1; i < 10000; i++)
            {
                userString += i.ToString() + ", ";
            }
            Console.WriteLine(userString);
        }
    }
}



