using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PinlessDebitReply
	{
		private string reasonCodeField;
		private string amountField;
		private string authorizationCodeField;
		private string requestDateTimeField;
		private string processorResponseField;
		private string receiptNumberField;
		private string reconciliationIDField;
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
		public string authorizationCode
		{
			get
			{
				return this.authorizationCodeField;
			}
			set
			{
				this.authorizationCodeField = value;
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
		public string receiptNumber
		{
			get
			{
				return this.receiptNumberField;
			}
			set
			{
				this.receiptNumberField = value;
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
	}
}
