using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCCaptureService
	{
		private string authTypeField;
		private string verbalAuthCodeField;
		private string authRequestIDField;
		private string reconciliationIDField;
		private string partialPaymentIDField;
		private string purchasingLevelField;
		private string industryDatatypeField;
		private string authRequestTokenField;
		private string merchantReceiptNumberField;
		private string runField;
		public string authType
		{
			get
			{
				return this.authTypeField;
			}
			set
			{
				this.authTypeField = value;
			}
		}
		public string verbalAuthCode
		{
			get
			{
				return this.verbalAuthCodeField;
			}
			set
			{
				this.verbalAuthCodeField = value;
			}
		}
		public string authRequestID
		{
			get
			{
				return this.authRequestIDField;
			}
			set
			{
				this.authRequestIDField = value;
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
		public string authRequestToken
		{
			get
			{
				return this.authRequestTokenField;
			}
			set
			{
				this.authRequestTokenField = value;
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
