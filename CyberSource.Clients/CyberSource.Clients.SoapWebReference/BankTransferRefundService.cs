using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BankTransferRefundService
	{
		private string bankTransferRequestIDField;
		private string bankTransferRealTimeRequestIDField;
		private string reconciliationIDField;
		private string bankTransferRealTimeReconciliationIDField;
		private string bankTransferRequestTokenField;
		private string bankTransferRealTimeRequestTokenField;
		private string runField;
		public string bankTransferRequestID
		{
			get
			{
				return this.bankTransferRequestIDField;
			}
			set
			{
				this.bankTransferRequestIDField = value;
			}
		}
		public string bankTransferRealTimeRequestID
		{
			get
			{
				return this.bankTransferRealTimeRequestIDField;
			}
			set
			{
				this.bankTransferRealTimeRequestIDField = value;
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
		public string bankTransferRealTimeReconciliationID
		{
			get
			{
				return this.bankTransferRealTimeReconciliationIDField;
			}
			set
			{
				this.bankTransferRealTimeReconciliationIDField = value;
			}
		}
		public string bankTransferRequestToken
		{
			get
			{
				return this.bankTransferRequestTokenField;
			}
			set
			{
				this.bankTransferRequestTokenField = value;
			}
		}
		public string bankTransferRealTimeRequestToken
		{
			get
			{
				return this.bankTransferRealTimeRequestTokenField;
			}
			set
			{
				this.bankTransferRealTimeRequestTokenField = value;
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
