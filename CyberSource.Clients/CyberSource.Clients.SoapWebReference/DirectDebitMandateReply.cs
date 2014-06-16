using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DirectDebitMandateReply
	{
		private string reasonCodeField;
		private string mandateIDField;
		private string mandateMaturationDateField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string processorResponseField;
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
		public string mandateID
		{
			get
			{
				return this.mandateIDField;
			}
			set
			{
				this.mandateIDField = value;
			}
		}
		public string mandateMaturationDate
		{
			get
			{
				return this.mandateMaturationDateField;
			}
			set
			{
				this.mandateMaturationDateField = value;
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
	}
}
