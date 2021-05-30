using System;

namespace EnumTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
           short[] Values = (short[])Enum.GetValues(typeof(Gender));
            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }
           string[] Names = Enum.GetNames(typeof(Gender));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
    public enum Gender : short
    {
        Unknown = 1,
        Male,
        Female
    }
}
