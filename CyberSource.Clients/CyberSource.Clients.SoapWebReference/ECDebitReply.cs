using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ECDebitReply
	{
		private string reasonCodeField;
		private string settlementMethodField;
		private string requestDateTimeField;
		private string amountField;
		private string verificationLevelField;
		private string processorTransactionIDField;
		private string reconciliationIDField;
		private string processorResponseField;
		private string avsCodeField;
		private string avsCodeRawField;
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
		public string requestDateTime
		{
			get
			{
				return this.requestDateTimeField;
			}
			set
			{
				this.requestDateTimeField = value;
			}
		}
		public string amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
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
		public string processorTransactionID
		{
			get
			{
				return this.processorTransactionIDField;
			}
			set
			{
				this.processorTransactionIDField = value;
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
		public string processorResponse
		{
			get
			{
				return this.processorResponseField;
			}
			set
			{
				this.processorResponseField = value;
			}
		}
		public string avsCode
		{
			get
			{
				return this.avsCodeField;
			}
			set
			{
				this.avsCodeField = value;
			}
		}
		public string avsCodeRaw
		{
			get
			{
				return this.avsCodeRawField;
			}
			set
			{
				this.avsCodeRawField = value;
			}
		}
	}
}
