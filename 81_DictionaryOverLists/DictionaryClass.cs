using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81_DictionaryOverLists
{
    public class DictionaryClass
    {
        public static void DictionaryOfCountries()
        {
            // Create countries
            Country country1 = new Country() { CountryCode = "AUS", Name = "AUSTRAILIA", Capital = "Canberra" };
            Country country2 = new Country() { CountryCode = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { CountryCode = "USA", Name = "USA", Capital = "Washington DC" };
            Country country4 = new Country() { CountryCode = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { CountryCode = "CAN", Name = "CANADA", Capital = "Ottawa" };

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.CountryCode, country1);
            dictionaryCountries.Add(country2.CountryCode, country2);
            dictionaryCountries.Add(country3.CountryCode, country3);
            dictionaryCountries.Add(country4.CountryCode, country4);
            dictionaryCountries.Add(country5.CountryCode, country5);

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Dictionary Example - Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

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
