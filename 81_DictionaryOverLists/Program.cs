using System;
using System.Collections.Generic;

namespace _81_DictionaryOverLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListClass.ListOfCountries();
            DictionaryClass.DictionaryOfCountries();
        }
    }
   
    public class Country
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Capital { get; set; }
    }
}
