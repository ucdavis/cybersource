using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayPalPaymentService
	{
		private string cancelURLField;
		private string successURLField;
		private string reconciliationIDField;
		private string runField;
		public string cancelURL
		{
			get
			{
				return this.cancelURLField;
			}
			set
			{
				this.cancelURLField = value;
			}
		}
		public string successURL
		{
			get
			{
				return this.successURLField;
			}
			set
			{
				this.successURLField = value;
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
