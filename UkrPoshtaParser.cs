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
        private HtmlWeb site;

        public UkrPoshtaParser()
        {
            this.site = new HtmlWeb();
        }

        public List<Country> GetShippingRates()
        {
            var htmlDoc = site.Load(URL);
            var table = htmlDoc.DocumentNode.SelectSingleNode("//tbody");
            
            var nodes = table.SelectNodes(".//tr");

            List<Country> shippingRates = new List<Country>();

            foreach (var node in nodes)
            {
                var nodeProperties = node.SelectNodes(".//td");

                for (int i = 0; i < nodeProperties.Count;)
                {
                    shippingRates.Add(new Country(nodeProperties[i].InnerText));

                    var country = shippingRates[shippingRates.Count - 1];

                    country.Code = $"{nodeProperties[++i].InnerText}";
                    country.LessThan10kgParcelRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    country.LessThan10kgByAirPerKiloRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    country.LessThan10kgByLandPerKiloRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    country.MoreThan10kgParcelRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    country.MoreThan10kgByAirPerKiloRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    country.MoreThan10kgByLandPerKiloRate = Convert.ToDouble($"{nodeProperties[++i].InnerText}");
                    i++;
                }
            }

            return shippingRates;
        }

        public bool TryGetShippingRates()
        {
            HtmlNode table;

            try
            {
                var htmlDoc = site.Load(URL);
                table = htmlDoc.DocumentNode.SelectSingleNode("//tbody");
            }
            catch (Exception)
            {
                return false;
            }

            var nodes = table.SelectNodes(".//tr");

            if (table is null || nodes.Count == 0)
            {
                return false;
            }
            else
            {               
                foreach (var node in nodes)
                {
                    var nodeProperties = node.SelectNodes(".//td");

                    if (nodeProperties.Count != 8)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}