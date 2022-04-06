using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebUI.Models.CurrencyRate
{
	[XmlRoot(ElementName = "Currency")]
	public class Currency
    {
		[XmlElement(ElementName = "Unit")]
		public int Unit { get; set; }

		[XmlElement(ElementName = "Isim")]
		public string Isim { get; set; }

		[XmlElement(ElementName = "CurrencyName")]
		public string CurrencyName { get; set; }

		[XmlElement(ElementName = "ForexBuying")]
		public double ForexBuying { get; set; }

		[XmlElement(ElementName = "ForexSelling")]
		public double ForexSelling { get; set; }

		[XmlElement(ElementName = "BanknoteBuying")]
		public double BanknoteBuying { get; set; }

		[XmlElement(ElementName = "BanknoteSelling")]
		public double BanknoteSelling { get; set; }

		[XmlElement(ElementName = "CrossRateUSD")]
		public object CrossRateUSD { get; set; }

		[XmlElement(ElementName = "CrossRateOther")]
		public object CrossRateOther { get; set; }

		[XmlAttribute(AttributeName = "CrossOrder")]
		public int CrossOrder { get; set; }

		[XmlAttribute(AttributeName = "Kod")]
		public string Kod { get; set; }

		[XmlAttribute(AttributeName = "CurrencyCode")]
		public string CurrencyCode { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
