using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayPalCreditService
	{
		private string payPalPaymentRequestIDField;
		private string reconciliationIDField;
		private string payPalPaymentRequestTokenField;
		private string runField;
		public string payPalPaymentRequestID
		{
			get
			{
				return this.payPalPaymentRequestIDField;
			}
			set
			{
				this.payPalPaymentRequestIDField = value;
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
		public string payPalPaymentRequestToken
		{
			get
			{
				return this.payPalPaymentRequestTokenField;
			}
			set
			{
				this.payPalPaymentRequestTokenField = value;
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
