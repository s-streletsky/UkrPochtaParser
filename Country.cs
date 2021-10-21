using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrPochtaParser
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double LessThan10kgParcelRate { get; set; }
        public double LessThan10kgByAirPerKiloRate { get; set; }
        public double LessThan10kgByLandPerKiloRate { get; set; }
        public double MoreThan10kgParcelRate { get; set; }
        public double MoreThan10kgByAirPerKiloRate { get; set; }
        public double MoreThan10kgByLandPerKiloRate { get; set; }

        public Country()
        {
        }

        public Country(string name)
        {
            this.Name = name;
        }
    }
}