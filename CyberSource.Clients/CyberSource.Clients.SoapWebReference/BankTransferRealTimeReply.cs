using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BankTransferRealTimeReply
	{
		private string reasonCodeField;
		private string formMethodField;
		private string formActionField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string paymentReferenceField;
		private string amountField;
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
		public string formMethod
		{
			get
			{
				return this.formMethodField;
			}
			set
			{
				this.formMethodField = value;
			}
		}
		public string formAction
		{
			get
			{
				return this.formActionField;
			}
			set
			{
				this.formActionField = value;
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
		public string paymentReference
		{
			get
			{
				return this.paymentReferenceField;
			}
			set
			{
				this.paymentReferenceField = value;
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
	}
}
