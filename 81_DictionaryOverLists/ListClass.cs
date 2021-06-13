using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81_DictionaryOverLists
{
    class ListClass
    {
        public static void ListOfCountries()
        {
            // Create countries
            Country country1 = new Country() { CountryCode = "AUS", Name = "AUSTRAILIA", Capital = "Canberra" };
            Country country2 = new Country() { CountryCode = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { CountryCode = "USA", Name = "USA", Capital = "Washington DC" };
            Country country4 = new Country() { CountryCode = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { CountryCode = "CAN", Name = "CANADA", Capital = "Ottawa" };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("List Example - Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                // Find if the input matches the list
                Country resultCountry = listCountries.Find(country => country.CountryCode == strCountryCode);
                if (resultCountry == null)
                    Console.WriteLine("Country code is not valid");
                else
                    Console.WriteLine($"Name: {resultCountry.Name}, Capital: {resultCountry.Capital}, Country code: {resultCountry.CountryCode}");

                do
                {
                    Console.WriteLine("Do you want to continue Y or N");
                    strUserChoice = Console.ReadLine().ToUpper();
                }
                while (strUserChoice != "Y" && strUserChoice != "N");
            }
            while (strUserChoice == "Y");
        }
    }
}
