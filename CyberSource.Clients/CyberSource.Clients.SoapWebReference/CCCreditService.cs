using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCCreditService
	{
		private string captureRequestIDField;
		private string reconciliationIDField;
		private string partialPaymentIDField;
		private string purchasingLevelField;
		private string industryDatatypeField;
		private string commerceIndicatorField;
		private string billPaymentField;
		private string authorizationXIDField;
		private string occurrenceNumberField;
		private string authCodeField;
		private string captureRequestTokenField;
		private string merchantReceiptNumberField;
		private string runField;
		public string captureRequestID
		{
			get
			{
				return this.captureRequestIDField;
			}
			set
			{
				this.captureRequestIDField = value;
			}
		}
		public string reconciliationID
		{
			get
			{
				return this.reconciliationIDField;
			}
			set
			{
				this.reconciliationIDField = value;
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
		public string purchasingLevel
		{
			get
			{
				return this.purchasingLevelField;
			}
			set
			{
				this.purchasingLevelField = value;
			}
		}
		public string industryDatatype
		{
			get
			{
				return this.industryDatatypeField;
			}
			set
			{
				this.industryDatatypeField = value;
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
		public string billPayment
		{
			get
			{
				return this.billPaymentField;
			}
			set
			{
				this.billPaymentField = value;
			}
		}
		public string authorizationXID
		{
			get
			{
				return this.authorizationXIDField;
			}
			set
			{
				this.authorizationXIDField = value;
			}
		}
		public string occurrenceNumber
		{
			get
			{
				return this.occurrenceNumberField;
			}
			set
			{
				this.occurrenceNumberField = value;
			}
		}
		public string authCode
		{
			get
			{
				return this.authCodeField;
			}
			set
			{
				this.authCodeField = value;
			}
		}
		public string captureRequestToken
		{
			get
			{
				return this.captureRequestTokenField;
			}
			set
			{
				this.captureRequestTokenField = value;
			}
		}
		public string merchantReceiptNumber
		{
			get
			{
				return this.merchantReceiptNumberField;
			}
			set
			{
				this.merchantReceiptNumberField = value;
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
