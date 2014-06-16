using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class OtherTax
	{
		private string vatTaxAmountField;
		private string vatTaxRateField;
		private string alternateTaxAmountField;
		private string alternateTaxIndicatorField;
		private string alternateTaxIDField;
		private string localTaxAmountField;
		private string localTaxIndicatorField;
		private string nationalTaxAmountField;
		private string nationalTaxIndicatorField;
		public string vatTaxAmount
		{
			get
			{
				return this.vatTaxAmountField;
			}
			set
			{
				this.vatTaxAmountField = value;
			}
		}
		public string vatTaxRate
		{
			get
			{
				return this.vatTaxRateField;
			}
			set
			{
				this.vatTaxRateField = value;
			}
		}
		public string alternateTaxAmount
		{
			get
			{
				return this.alternateTaxAmountField;
			}
			set
			{
				this.alternateTaxAmountField = value;
			}
		}
		public string alternateTaxIndicator
		{
			get
			{
				return this.alternateTaxIndicatorField;
			}
			set
			{
				this.alternateTaxIndicatorField = value;
			}
		}
		public string alternateTaxID
		{
			get
			{
				return this.alternateTaxIDField;
			}
			set
			{
				this.alternateTaxIDField = value;
			}
		}
		public string localTaxAmount
		{
			get
			{
				return this.localTaxAmountField;
			}
			set
			{
				this.localTaxAmountField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string localTaxIndicator
		{
			get
			{
				return this.localTaxIndicatorField;
			}
			set
			{
				this.localTaxIndicatorField = value;
			}
		}
		public string nationalTaxAmount
		{
			get
			{
				return this.nationalTaxAmountField;
			}
			set
			{
				this.nationalTaxAmountField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string nationalTaxIndicator
		{
			get
			{
				return this.nationalTaxIndicatorField;
			}
			set
			{
				this.nationalTaxIndicatorField = value;
			}
		}
	}
}
