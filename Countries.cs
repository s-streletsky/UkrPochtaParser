using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrPochtaParser
{
    [Serializable]
    public class Countries
    {
        public List<Country> List { get; } = new List<Country>();
        public List<string> CountriesListContent { get; } = new List<string>();

        public void ParseSourceStringToList(string sourceString)
        {
            char tab = '\u0009';
            string source = sourceString.Replace(tab.ToString(), ""); //удаляем Tab'ы из входящей строки

            String[] tariffs = source.Split('\n'); //разбиваем строку на массив строк

            List<string> tempList = new List<string>();

            foreach (var item in tariffs) //проверяем содержимое строк и добавляем в список
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    //var _item = item.Replace(',', '.');
                    tempList.Add(item);
                }
            }

            for (int i = 0; i < tempList.Count; i += 8) //заполняем this.List объектами типа Country
            {
                this.List.Add(new Country(tempList[i]));

                this.List[List.Count - 1].Code = $"{tempList[i + 1]}";
                this.List[List.Count - 1].LessThan10kgParcelRate = Convert.ToDouble($"{tempList[i + 2]}");
                this.List[List.Count - 1].LessThan10kgByAirPerKiloRate = Convert.ToDouble($"{tempList[i + 3]}");
                this.List[List.Count - 1].LessThan10kgByLandPerKiloRate = Convert.ToDouble($"{tempList[i + 4]}");
                this.List[List.Count - 1].MoreThan10kgParcelRate = Convert.ToDouble($"{tempList[i + 5]}");
                this.List[List.Count - 1].MoreThan10kgByAirPerKiloRate = Convert.ToDouble($"{tempList[i + 6]}");
                this.List[List.Count - 1].MoreThan10kgByLandPerKiloRate = Convert.ToDouble($"{tempList[i + 7]}");               
            }          
        }

        public void AddCountriesListContent() //данные для списка стран в форме
        {
            for (int i = 0; i < List.Count; i++)
            {
                this.CountriesListContent.Add(List[i].Name);
            }  
        }
    }
}