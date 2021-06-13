using System;
using System.Collections.Generic;

namespace _77SortingAList
{
    class SimpleTypeSorting
    {
        static void Main(string[] args)
        {

            //List of int - simple type
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 6, 3, 4, 9, 2 };
            Console.WriteLine($"Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine($"\nNumbers after sorting");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine($"\nNumbers in decending order");
            numbers.Reverse();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            // list of strings
            List<string> alphabet = new List<string>() { "B", "R", "Y", "D", "K", "A" };
            Console.WriteLine($"\nLetters before sorting");
            foreach (string letter in alphabet)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine($"\nLetters after sorting");
            alphabet.Sort();
            foreach (string letter in alphabet)
            {
                Console.Write($"{letter} ");
            }
            Console.ReadKey();
        }
    }
}
