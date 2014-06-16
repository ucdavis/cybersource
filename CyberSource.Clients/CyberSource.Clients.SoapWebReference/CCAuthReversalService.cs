using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCAuthReversalService
	{
		private string authRequestIDField;
		private string authRequestTokenField;
		private string runField;
		public string authRequestID
		{
			get
			{
				return this.authRequestIDField;
			}
			set
			{
				this.authRequestIDField = value;
			}
		}
		public string authRequestToken
		{
			get
			{
				return this.authRequestTokenField;
			}
			set
			{
				this.authRequestTokenField = value;
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
