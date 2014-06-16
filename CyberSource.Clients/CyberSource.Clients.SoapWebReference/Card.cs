using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Card
	{
		private string fullNameField;
		private string accountNumberField;
		private string expirationMonthField;
		private string expirationYearField;
		private string cvIndicatorField;
		private string cvNumberField;
		private string cardTypeField;
		private string issueNumberField;
		private string startMonthField;
		private string startYearField;
		private string pinField;
		private string accountEncoderIDField;
		private string binField;
		public string fullName
		{
			get
			{
				return this.fullNameField;
			}
			set
			{
				this.fullNameField = value;
			}
		}
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
		[XmlElement(DataType = "integer")]
		public string expirationMonth
		{
			get
			{
				return this.expirationMonthField;
			}
			set
			{
				this.expirationMonthField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string expirationYear
		{
			get
			{
				return this.expirationYearField;
			}
			set
			{
				this.expirationYearField = value;
			}
		}
		public string cvIndicator
		{
			get
			{
				return this.cvIndicatorField;
			}
			set
			{
				this.cvIndicatorField = value;
			}
		}
		public string cvNumber
		{
			get
			{
				return this.cvNumberField;
			}
			set
			{
				this.cvNumberField = value;
			}
		}
		public string cardType
		{
			get
			{
				return this.cardTypeField;
			}
			set
			{
				this.cardTypeField = value;
			}
		}
		public string issueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string startMonth
		{
			get
			{
				return this.startMonthField;
			}
			set
			{
				this.startMonthField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string startYear
		{
			get
			{
				return this.startYearField;
			}
			set
			{
				this.startYearField = value;
			}
		}
		public string pin
		{
			get
			{
				return this.pinField;
			}
			set
			{
				this.pinField = value;
			}
		}
		public string accountEncoderID
		{
			get
			{
				return this.accountEncoderIDField;
			}
			set
			{
				this.accountEncoderIDField = value;
			}
		}
		public string bin
		{
			get
			{
				return this.binField;
			}
			set
			{
				this.binField = value;
			}
		}
	}
}
