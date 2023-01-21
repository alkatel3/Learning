using System;

namespace CountriesTranslator
{
    static class AddCountries
    {
        public static void AddingCountry(string County, string TranslateCountry)
        {
            for (char i = 'A'; i < 'Z'; i++)
            {
                if (County[0] == i || County[0] == i.ToString().ToLower().ToCharArray()[0])
                {
                    TranslatorFromUK.Countries.Add(County, TranslateCountry);
                    TranslatorFromUA.Countries.Add(TranslateCountry, County);
                    return;
                }
            }
            TranslatorFromUA.Countries.Add(County, TranslateCountry);
            TranslatorFromUK.Countries.Add(TranslateCountry, County);
        }
    }
}
