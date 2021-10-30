using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            mainView.WeightInputKeyPress += OnWeightInputKeyPress;
        }

        private void OnGetCountriesButtonClick(object sender, EventArgs e)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "ShippingRates.xml");

            if (File.Exists(filePath)) //Если файл с тарифами существует,
            {
                bool initialized = repo.TryLoad(filePath); //пробуем загрузить,

                if (initialized) //если получилось,
                {
                    List<Country> deserializedList = repo.Load(filePath); //десериализируем его,
                    shippingRates.List.AddRange(deserializedList); //копируем содержимое в переменную.

                    mainView.IsCalculateShippingButtonEnabled = true;
                    mainView.StatusBarText = $"Тарифная сетка успешно загружена из файла ShippingRates.xml (создан {File.GetCreationTime(filePath)})";
                }             
            }
            else //Если же файл отсутствует или битый,
            {
                ukrPoshtaParser = new UkrPoshtaParser();
                bool parsed = ukrPoshtaParser.TryGetShippingRates(); //пытаемся парсить сайт,

                if (parsed) //если получилось,
                {
                    List<Country> parsedList = ukrPoshtaParser.GetShippingRates(); //принимаем список объектов,
                    shippingRates.List.AddRange(parsedList); //копируем содержимое в переменную,
                    repo.Save(filePath, parsedList); //сохраняем в файл.

                    mainView.IsCalculateShippingButtonEnabled = true;
                    mainView.StatusBarText = $"Тарифная сетка успешно получена с сайта Укрпочты и сохранена в файл ShippingRates.xml";
                }
                else
                {
                    mainView.PrintUserMessage("ОШИБКА! Не удалось загрузить тарифную сетку! Возможные неполадки: " +
                        "отсутствует соединение с интернетом, сайт Укрпочты недоступен или изменился формат получаемых данных.");
                    mainView.StatusBarText = $"Ошибка загрузки!";
                }
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

            mainView.PrintUserMessage(text);
        }

        private void OnCalculateShippingButtonClick(object sender, EventArgs e)
        {
            double a, b;
            var c = Math.Round(Convert.ToDouble(mainView.WeightInput), 2);

            if (c < 1)
            {
                c = 1;
                mainView.WeightInput = "1";
            }

            if (c < 10)
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

        private void OnWeightInputKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
