using System;

namespace DelegatesMulticast
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodThree;
            del += SampleMethodTwo;

            int DelegateOutputParmeterValue = 1;
            del(out DelegateOutputParmeterValue);

            Console.WriteLine($"Last added delegate in invokation list: {DelegateOutputParmeterValue}");
            Console.ReadKey();
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
        public static void SampleMethodThree(out int Number)
        {
            Number = 3;
        }
    }
}
