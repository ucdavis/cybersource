using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class FundTransfer
	{
		private string accountNumberField;
		private string accountNameField;
		private string bankCheckDigitField;
		private string ibanField;
		public string accountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.accountNumberField = value;
			}
		}
		public string accountName
		{
			get
			{
				return this.accountNameField;
			}
			set
			{
				this.accountNameField = value;
			}
		}
		public string bankCheckDigit
		{
			get
			{
				return this.bankCheckDigitField;
			}
			set
			{
				this.bankCheckDigitField = value;
			}
		}
		public string iban
		{
			get
			{
				return this.ibanField;
			}
			set
			{
				this.ibanField = value;
			}
		}
	}
}
