using NLog;
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
        private Logger log;

        public Repository()
        {
            this.serializer = new XmlSerializer(typeof(List<Country>));
            this.log = LogManager.GetCurrentClassLogger();
        }

        public void Save(string filePath, List<Country> parsedList)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, parsedList);
            }
        }

        public bool TryLoad(string filePath, out List<Country> loadedList)
        {
            loadedList = null;

            if (!File.Exists(filePath))
            {
                return false;
            }
            else
            {
                try
                {
                    loadedList = Load(filePath);
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                    return false;
                }
            }

            return true;
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
