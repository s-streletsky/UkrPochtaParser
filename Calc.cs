using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrPochtaInternationShippingCalc
{
    static class Calc
    {
        public static double CalculateShippingCost(double perParcel, double perKilo, double weight)
        {
            var x = perKilo * weight + perParcel;
            return x;
        }
    }
}
