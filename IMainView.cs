using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrPochtaInternationShippingCalc
{
    interface IMainView
    {
        int CountriesListIndex { get; set; }
        string WeightInput { get; set; }
        string StatusBarText { get; set; }
        bool IsByAirChecked { get; set; }
        bool IsGetCountriesButtonEnabled { get; set; }
        bool IsCalculateShippingButtonEnabled { get; set; }
        void SetCountriesList(List<string> countries);
        void PrintShippingCost(string cost);
        void PrintUserMessage(string details);

        event EventHandler GetCountriesButtonClick;

        event EventHandler CountriesListIndexChanged;

        event EventHandler CalculateShippingButtonClick;

        event KeyPressEventHandler WeightInputKeyPress;
    }
}
