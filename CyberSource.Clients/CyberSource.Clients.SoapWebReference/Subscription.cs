using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Subscription
	{
		private string titleField;
		private string paymentMethodField;
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}
		public string paymentMethod
		{
			get
			{
				return this.paymentMethodField;
			}
			set
			{
				this.paymentMethodField = value;
			}
		}
	}
}
