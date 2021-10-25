using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrPochtaInternationShippingCalc
{
    [Serializable]
    class ShippingRates
    {
        public List<Country> List { get; } = new List<Country>();
        public List<string> CountriesListContent { get; } = new List<string>();

        public void AddCountriesListContent()
        {
            foreach (var country in List)
            {
                CountriesListContent.Add(country.Name);
            }
        }
    }
}
