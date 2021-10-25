using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrPochtaInternationShippingCalc
{
    interface IMainView
    {
        int CountriesListIndex { get; set; }
        string WeightInput { get; set; }
        bool IsLessThan10kgChecked { get; set; }
        bool IsByAirChecked { get; set; }
        bool IsGetCountriesButtonEnabled { get; set; }
        void SetCountriesList(List<string> countries);
        void PrintShippingCost(string cost);
        void PrintCountryDetails(string details);

        event EventHandler GetCountriesButtonClick;

        event EventHandler CountriesListIndexChanged;

        event EventHandler CalculateShippingButtonClick;
    }
}
