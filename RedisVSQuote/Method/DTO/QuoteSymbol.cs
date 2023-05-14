using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RedisVSQuote.Method.DTO
{
    [XmlRoot(ElementName = "Symbols")]
    public class QuoteSymbol
    {
        [XmlElement("Symbol")]
        public Symbol[] SymbolList { get; set; }
    }
    public class Symbol
    {
        [XmlAttribute("id")]
        public string id { get; set; }

        [XmlAttribute("dealprice")]
        public string dealprice { get; set; }

        [XmlAttribute("shortname")]
        public string shortname { get; set; }
    }
}
