using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace UkrPochtaParser
{
    class Source
    {
        public string Address { get; }

        public Source(string url)
        {
            this.Address = url;
        }

        public string GetInnerText()
        {
            HtmlWeb site = new HtmlWeb();

            var htmlDoc = site.Load(this.Address);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//tbody");

            return node.InnerText;
        }
    }
}