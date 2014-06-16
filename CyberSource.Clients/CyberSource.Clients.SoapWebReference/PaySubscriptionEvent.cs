using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PaySubscriptionEvent
	{
		private string amountField;
		private string approvedByField;
		private string numberField;
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
		public string approvedBy
		{
			get
			{
				return this.approvedByField;
			}
			set
			{
				this.approvedByField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string number
		{
			get
			{
				return this.numberField;
			}
			set
			{
				this.numberField = value;
			}
		}
	}
}
