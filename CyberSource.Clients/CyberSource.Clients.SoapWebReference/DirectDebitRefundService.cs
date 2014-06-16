using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DirectDebitRefundService
	{
		private string directDebitRequestIDField;
		private string reconciliationIDField;
		private string directDebitRequestTokenField;
		private string runField;
		public string directDebitRequestID
		{
			get
			{
				return this.directDebitRequestIDField;
			}
			set
			{
				this.directDebitRequestIDField = value;
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
		public string directDebitRequestToken
		{
			get
			{
				return this.directDebitRequestTokenField;
			}
			set
			{
				this.directDebitRequestTokenField = value;
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
