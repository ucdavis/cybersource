using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class FXQuote
	{
		private string idField;
		private string rateField;
		private string typeField;
		private string expirationDateTimeField;
		private string currencyField;
		private string fundingCurrencyField;
		private string receivedDateTimeField;
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		public string rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
			}
		}
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		public string expirationDateTime
		{
			get
			{
				return this.expirationDateTimeField;
			}
			set
			{
				this.expirationDateTimeField = value;
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
		public string fundingCurrency
		{
			get
			{
				return this.fundingCurrencyField;
			}
			set
			{
				this.fundingCurrencyField = value;
			}
		}
		public string receivedDateTime
		{
			get
			{
				return this.receivedDateTimeField;
			}
			set
			{
				this.receivedDateTimeField = value;
			}
		}
	}
}
