using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrPochtaInternationShippingCalc
{
    public partial class MainView : Form, IMainView
    {
        public bool IsGetCountriesButtonEnabled { 
            get => getCountriesButton.Enabled; 
            set => getCountriesButton.Enabled = value; 
        }
        public string WeightInput { 
            get => weightInput.Text; 
            set => weightInput.Text = value; 
        }
        public int CountriesListIndex { 
            get => countriesList.SelectedIndex; 
            set => countriesList.SelectedIndex = value; 
        }
        public bool IsByAirChecked { 
            get => byAir.Checked; 
            set => byAir.Checked = value; 
        }
        public bool IsCalculateShippingButtonEnabled 
        { 
            get => calculateShippingButton.Enabled; 
            set => calculateShippingButton.Enabled = value; 
        }
        public string StatusBarText
        { 
            get => toolStripStatusLabel1.Text; 
            set => toolStripStatusLabel1.Text = value; 
        }

        public MainView()
        {
            InitializeComponent();
            new Presenter(this);
        }

        event EventHandler IMainView.GetCountriesButtonClick
        {
            add
            {
                getCountriesButton.Click += value;
            }

            remove
            {
                getCountriesButton.Click -= value;
            }
        }

        event EventHandler IMainView.CalculateShippingButtonClick
        {
            add
            {
                calculateShippingButton.Click += value;
            }

            remove
            {
                calculateShippingButton.Click -= value;
            }
        }

        event EventHandler IMainView.CountriesListIndexChanged
        {
            add
            {
                countriesList.SelectedIndexChanged += value;
            }

            remove
            {
                countriesList.SelectedIndexChanged -= value;
            }
        }

        event KeyPressEventHandler IMainView.WeightInputKeyPress
        {
            add
            {
                weightInput.KeyPress += value;
            }

            remove
            {
                weightInput.KeyPress -= value;
            }
        }

        //private void CalculateShippingButtonClick(object sender, EventArgs e)
        //{
        //}

        //private void GetCountriesButtonClick(object sender, EventArgs e)
        //{
        //}

        //private void CountriesListIndexChange(object sender, EventArgs e)
        //{
        //}

        public void SetCountriesList(List<string> countries)
        {
            countriesList.DataSource = countries;
        }

        public void PrintShippingCost(string cost)
        {
            shippingCostOutput.Text = cost;
        }

        public void PrintUserMessage(string countryDetails)
        {
            messageBox.Text = countryDetails;
        }
    }
}
