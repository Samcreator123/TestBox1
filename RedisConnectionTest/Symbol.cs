using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RedisConnectionTest
{
    [XmlRoot(ElementName = "Symbol")]
    public class Symbol
    {
        [XmlAttribute(AttributeName = "shortname")]
        public string ShortName { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "dealprice")]
        public decimal DealPrice { get; set; }

        [XmlAttribute(AttributeName = "refprice")]
        public string RefPrice { get; set; }

        [XmlAttribute(AttributeName = "updown")]
        public string UpDown { get; set; }

        [XmlAttribute(AttributeName = "updownrate")]
        public string UpDownRate { get; set; }

        [XmlAttribute(AttributeName = "volume")]
        public int Volume { get; set; }

        [XmlAttribute(AttributeName = "open")]
        public decimal Open { get; set; }

        [XmlAttribute(AttributeName = "high")]
        public decimal High { get; set; }

        [XmlAttribute(AttributeName = "low")]
        public decimal Low { get; set; }

        [XmlAttribute(AttributeName = "moddate")]
        public string ModDate { get; set; }

        [XmlAttribute(AttributeName = "modtime")]
        public string ModTime { get; set; }
    }
}
