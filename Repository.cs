using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UkrPochtaInternationShippingCalc
{
    class Repository
    {
        private XmlSerializer serializer;

        public Repository()
        {
            this.serializer = new XmlSerializer(typeof(List<Country>));
        }
        public void Save(string filePath, List<Country> parsedList)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, parsedList);
            }
        }

        public List<Country> Load(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Country>)serializer.Deserialize(fs);
            }
        }

        public void Update()
        {
        }
    }
}
