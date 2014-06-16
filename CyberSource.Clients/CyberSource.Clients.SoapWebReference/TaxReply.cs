using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class TaxReply
	{
		private string reasonCodeField;
		private string currencyField;
		private string grandTotalAmountField;
		private string totalCityTaxAmountField;
		private string cityField;
		private string totalCountyTaxAmountField;
		private string countyField;
		private string totalDistrictTaxAmountField;
		private string totalStateTaxAmountField;
		private string stateField;
		private string totalTaxAmountField;
		private string postalCodeField;
		private string geocodeField;
		private TaxReplyItem[] itemField;
		[XmlElement(DataType = "integer")]
		public string reasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
		public string currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
		public string grandTotalAmount
		{
			get
			{
				return this.grandTotalAmountField;
			}
			set
			{
				this.grandTotalAmountField = value;
			}
		}
		public string totalCityTaxAmount
		{
			get
			{
				return this.totalCityTaxAmountField;
			}
			set
			{
				this.totalCityTaxAmountField = value;
			}
		}
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		public string totalCountyTaxAmount
		{
			get
			{
				return this.totalCountyTaxAmountField;
			}
			set
			{
				this.totalCountyTaxAmountField = value;
			}
		}
		public string county
		{
			get
			{
				return this.countyField;
			}
			set
			{
				this.countyField = value;
			}
		}
		public string totalDistrictTaxAmount
		{
			get
			{
				return this.totalDistrictTaxAmountField;
			}
			set
			{
				this.totalDistrictTaxAmountField = value;
			}
		}
		public string totalStateTaxAmount
		{
			get
			{
				return this.totalStateTaxAmountField;
			}
			set
			{
				this.totalStateTaxAmountField = value;
			}
		}
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		public string totalTaxAmount
		{
			get
			{
				return this.totalTaxAmountField;
			}
			set
			{
				this.totalTaxAmountField = value;
			}
		}
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		public string geocode
		{
			get
			{
				return this.geocodeField;
			}
			set
			{
				this.geocodeField = value;
			}
		}
		[XmlElement("item")]
		public TaxReplyItem[] item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}
}
