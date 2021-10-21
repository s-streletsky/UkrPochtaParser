using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UkrPochtaParser
{
    class Presenter
    {
        public IMainView mainView;
        private Source source;
        private Countries countries;
        public Presenter(IMainView i)
        {
            this.mainView = i;
            this.source = new Source("https://www.ukrposhta.ua/ru/taryfy-mizhnarodni-vidpravlennia-posylky");
            this.countries = new Countries();
            mainView.GetCountriesButtonClick += OnGetCountriesButtonClick;
            mainView.CalculateShippingButtonClick += OnCalculateShippingButtonClick;
            mainView.CountriesListIndexChanged += OnCountriesListIndexChange;
        }

        //private void OnGetCountriesButtonClick(object sender, EventArgs e)
        //{
        //    countries.ParseSourceStringToList(source.GetInnerText());

        //    var dirPath = "D://Prog//UkrPochtaParser/";
        //    var file = new FileInfo(dirPath + "ShippingRates.xml");

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Country>));

        //    serializer.Serialize(new FileStream(dirPath + "ShippingRates.xml", FileMode.OpenOrCreate), countries.List);

        //    mainView.SetCountriesList(countries.CountriesListContent);

        //    mainView.IsGetCountriesButtonEnabled = false;
        //}

        private void OnGetCountriesButtonClick(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Country>));
            var path = "D://Prog//UkrPochtaParser//ShippingRates.xml";

            if (File.Exists(path))
            {
                countries.List.AddRange((List<Country>)serializer.Deserialize(new FileStream(path, FileMode.Open)));
            }
            else
            {
                countries.ParseSourceStringToList(source.GetInnerText());
                serializer.Serialize(new FileStream(path, FileMode.Create), countries.List);
            }

            countries.AddCountriesListContent();

            mainView.SetCountriesList(countries.CountriesListContent);

            mainView.IsGetCountriesButtonEnabled = false;
        }

        private void OnCountriesListIndexChange(object sender, EventArgs e)
        {
            mainView.PrintCountryDetails($"Ориентировочная стоимость доставки Укрпочтой по направлению Украина — {countries.List[mainView.CountriesListIndex].Name} составит: " +
                $"{countries.List[mainView.CountriesListIndex].LessThan10kgParcelRate}$ за единицу отправления + {countries.List[mainView.CountriesListIndex].LessThan10kgByAirPerKiloRate}$ " +
                $"за каждый кг веса (включая упаковку). Указанные тарифы актуальны для посылок массой менее 10 кг без объявленной ценности. Доставка " +
                $"осуществляется авиатранспортом (наиболее быстрый способ).");
        }

        private void OnCalculateShippingButtonClick(object sender, EventArgs e)
        {
            double a, b;
            var c = Convert.ToDouble(mainView.WeightInput);

            if (mainView.IsLessThan10kgChecked)
            {
                a = countries.List[mainView.CountriesListIndex].LessThan10kgParcelRate;

                if (mainView.IsByAirChecked)
                {
                    b = countries.List[mainView.CountriesListIndex].LessThan10kgByAirPerKiloRate;
                }
                else
                {
                    b = countries.List[mainView.CountriesListIndex].LessThan10kgByLandPerKiloRate;
                }
            }
            else
            {
                a = countries.List[mainView.CountriesListIndex].MoreThan10kgParcelRate;

                if (mainView.IsByAirChecked)
                {
                    b = countries.List[mainView.CountriesListIndex].MoreThan10kgByAirPerKiloRate;
                }
                else
                {
                    b = countries.List[mainView.CountriesListIndex].MoreThan10kgByLandPerKiloRate;
                }
            }

            mainView.PrintShippingCost(Calc.CalculateShippingCost(a, b, c).ToString());
        }
    }
}
