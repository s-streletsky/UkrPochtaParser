using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UkrPochtaInternationShippingCalc
{
    class Presenter
    {
        public IMainView mainView;
        private UkrPoshtaParser ukrPoshtaParser;
        private ShippingRates shippingRates;
        private Repository repo;
        public Presenter(IMainView i)
        {
            this.mainView = i;
            this.shippingRates = new ShippingRates();
            this.repo = new Repository();
            mainView.GetCountriesButtonClick += OnGetCountriesButtonClick;
            mainView.CalculateShippingButtonClick += OnCalculateShippingButtonClick;
            mainView.CountriesListIndexChanged += OnCountriesListIndexChange;
        }

        private void OnGetCountriesButtonClick(object sender, EventArgs e)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "ShippingRates.xml");

            if (File.Exists(filePath))
            {
                var deserializedList = repo.Load(filePath);
                shippingRates.List.AddRange(deserializedList);              
            }
            else
            {
                ukrPoshtaParser = new UkrPoshtaParser();
                var parsedList = ukrPoshtaParser.GetShippingRates();
                
                shippingRates.List.AddRange(parsedList);

                repo.Save(filePath, parsedList);              
            }

            shippingRates.AddCountriesListContent();

            mainView.SetCountriesList(shippingRates.CountriesListContent);

            mainView.IsGetCountriesButtonEnabled = false;
        }

        private void OnCountriesListIndexChange(object sender, EventArgs e)
        {
            var text = $"Ориентировочная стоимость доставки Укрпочтой по направлению Украина — {shippingRates.List[mainView.CountriesListIndex].Name} составит: " +
                       $"{shippingRates.List[mainView.CountriesListIndex].LessThan10kgParcelRate}$ за единицу отправления + {shippingRates.List[mainView.CountriesListIndex].LessThan10kgByAirPerKiloRate}$ " +
                       $"за каждый кг веса (включая упаковку). Указанные тарифы актуальны для посылок массой менее 10 кг без объявленной ценности. Доставка " +
                       $"осуществляется авиатранспортом (наиболее быстрый способ).";

            mainView.PrintCountryDetails(text);
        }

        private void OnCalculateShippingButtonClick(object sender, EventArgs e)
        {
            double a, b;
            var c = Convert.ToDouble(mainView.WeightInput);

            if (mainView.IsLessThan10kgChecked)
            {
                a = shippingRates.List[mainView.CountriesListIndex].LessThan10kgParcelRate;

                if (mainView.IsByAirChecked)
                {
                    b = shippingRates.List[mainView.CountriesListIndex].LessThan10kgByAirPerKiloRate;
                }
                else
                {
                    b = shippingRates.List[mainView.CountriesListIndex].LessThan10kgByLandPerKiloRate;
                }
            }
            else
            {
                a = shippingRates.List[mainView.CountriesListIndex].MoreThan10kgParcelRate;

                if (mainView.IsByAirChecked)
                {
                    b = shippingRates.List[mainView.CountriesListIndex].MoreThan10kgByAirPerKiloRate;
                }
                else
                {
                    b = shippingRates.List[mainView.CountriesListIndex].MoreThan10kgByLandPerKiloRate;
                }
            }

            mainView.PrintShippingCost(Calc.CalculateShippingCost(a, b, c).ToString());
        }
    }
}
