using System;
using WorldNameSpace;

namespace CountryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.English.ToString();
            countryLanguages.SecondLanguage = Languages.French.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Canda";
            countryOneInstance.Currency = Currencies.CAD;
            countryOneInstance.Continents = Continents.NorthAmerica;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);

            Console.WriteLine($"Planet {countryOneInstance.PlanetName} and country is {countryOneInstance.CountryName} and currency is {countryOneInstance.Currency}");
        }
    }
}
