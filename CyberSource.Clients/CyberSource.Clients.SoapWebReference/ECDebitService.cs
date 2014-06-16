using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ECDebitService
	{
		private string paymentModeField;
		private string referenceNumberField;
		private string settlementMethodField;
		private string transactionTokenField;
		private string verificationLevelField;
		private string partialPaymentIDField;
		private string commerceIndicatorField;
		private string runField;
		[XmlElement(DataType = "integer")]
		public string paymentMode
		{
			get
			{
				return this.paymentModeField;
			}
			set
			{
				this.paymentModeField = value;
			}
		}
		public string referenceNumber
		{
			get
			{
				return this.referenceNumberField;
			}
			set
			{
				this.referenceNumberField = value;
			}
		}
		public string settlementMethod
		{
			get
			{
				return this.settlementMethodField;
			}
			set
			{
				this.settlementMethodField = value;
			}
		}
		public string transactionToken
		{
			get
			{
				return this.transactionTokenField;
			}
			set
			{
				this.transactionTokenField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string verificationLevel
		{
			get
			{
				return this.verificationLevelField;
			}
			set
			{
				this.verificationLevelField = value;
			}
		}
		public string partialPaymentID
		{
			get
			{
				return this.partialPaymentIDField;
			}
			set
			{
				this.partialPaymentIDField = value;
			}
		}
		public string commerceIndicator
		{
			get
			{
				return this.commerceIndicatorField;
			}
			set
			{
				this.commerceIndicatorField = value;
			}
		}
		[XmlAttribute]
		public string run
		{
			get
			{
				return this.runField;
			}
			set
			{
				this.runField = value;
			}
		}
	}
}
