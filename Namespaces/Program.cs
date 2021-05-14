using System;

namespace Namespaces
{
    using PATA = ProjectA.TeamA;
    using PATB = ProjectB.TeamB;
    class Program
    {
        static void Main(string[] args)
        {
           
            PATA.ClassA.Print();
            PATB.ClassA.Print();

            Console.ReadKey();
        }
    }

    namespace ProjectA 
    { 
        namespace TeamA
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Team A Print Method");
                }
            }
        }
    }

    namespace ProjectB
    {
        namespace TeamB
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Team B Print Method");
                }
            }
        }
    }
}

