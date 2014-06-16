using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PaySubscriptionCreateService
	{
		private string paymentRequestIDField;
		private string paymentRequestTokenField;
		private string disableAutoAuthField;
		private string runField;
		public string paymentRequestID
		{
			get
			{
				return this.paymentRequestIDField;
			}
			set
			{
				this.paymentRequestIDField = value;
			}
		}
		public string paymentRequestToken
		{
			get
			{
				return this.paymentRequestTokenField;
			}
			set
			{
				this.paymentRequestTokenField = value;
			}
		}
		public string disableAutoAuth
		{
			get
			{
				return this.disableAutoAuthField;
			}
			set
			{
				this.disableAutoAuthField = value;
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
