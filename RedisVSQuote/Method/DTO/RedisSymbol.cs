using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RedisVSQuote.Method.DTO
{
    [XmlRoot(ElementName = "Symbol")]
    public class RedisSymbol
    {
        [XmlAttribute(AttributeName = "shortname")]
        public string ShortName { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "dealprice")]
        public string DealPrice { get; set; }

        [XmlAttribute(AttributeName = "refprice")]
        public string RefPrice { get; set; }

        [XmlAttribute(AttributeName = "updown")]
        public string UpDown { get; set; }

        [XmlAttribute(AttributeName = "updownrate")]
        public string UpDownRate { get; set; }

        [XmlAttribute(AttributeName = "volume")]
        public string Volume { get; set; }

        [XmlAttribute(AttributeName = "open")]
        public string Open { get; set; }

        [XmlAttribute(AttributeName = "high")]
        public string High { get; set; }

        [XmlAttribute(AttributeName = "low")]
        public string Low { get; set; }

        [XmlAttribute(AttributeName = "moddate")]
        public string ModDate { get; set; }

        [XmlAttribute(AttributeName = "modtime")]
        public string ModTime { get; set; }
    }
}
