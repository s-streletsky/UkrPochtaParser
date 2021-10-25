using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace UkrPochtaInternationShippingCalc
{
    class UkrPoshtaParser
    {
        private const string URL = "https://www.ukrposhta.ua/ru/taryfy-mizhnarodni-vidpravlennia-posylky";
        public List<Country> GetShippingRates()
        {
            HtmlWeb site = new HtmlWeb();

            var htmlDoc = site.Load(URL);
            var table = htmlDoc.DocumentNode.SelectSingleNode("//tbody");
            var nodes = table.SelectNodes(".//tr/td");

            List<Country> shippingRates = new List<Country>();

            for (int i = 0; i < nodes.Count;)
            {
                shippingRates.Add(new Country(nodes[i].InnerText));

                var country = shippingRates[shippingRates.Count - 1];

                country.Code = $"{nodes[++i].InnerText}";
                country.LessThan10kgParcelRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                country.LessThan10kgByAirPerKiloRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                country.LessThan10kgByLandPerKiloRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                country.MoreThan10kgParcelRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                country.MoreThan10kgByAirPerKiloRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                country.MoreThan10kgByLandPerKiloRate = Convert.ToDouble($"{nodes[++i].InnerText}");
                i++;
            }

            return shippingRates;
        }
    }
}