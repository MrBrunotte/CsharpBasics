using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoops();
            Console.WriteLine("\n");
            ForLoopWithBreak();
            Console.WriteLine("\n");
            ForLoopWithContinue();
        }

        private static void ForLoopWithContinue()
        {
            Console.WriteLine("Using a Continue keyword in the for loop");
            for (int i = 0; i <= 20; i++)
            {
                if (i %2 == 1)
                    continue;

                Console.Write($"{i} ");
               
            }
        }

        private static void ForLoopWithBreak()
        {
            Console.WriteLine("Using a break keyword in the for loop");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i} ");
                if (i == 10)
                {
                    break;
                }
            }
        }

        private static void ForLoops()
        {
            int[] Numbers = new int[3];
            
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            Console.WriteLine("Foreach loop");
            Console.WriteLine("basically used for to iterate through a collection");
            foreach (var k in Numbers)
            {
                Console.WriteLine(k);
            }


            Console.WriteLine("\nFor loop");
            Console.WriteLine("must now the lenght of the collection");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            Console.WriteLine("\nWhile loop");
            int j = 0;
            while (j < Numbers.Length)
            {
                Console.WriteLine(Numbers[j]);
                j++;
            }
        }
    }
}
