using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DecisionReply
	{
		private ProfileReply activeProfileReplyField;
		private string velocityInfoCodeField;
		public ProfileReply activeProfileReply
		{
			get
			{
				return this.activeProfileReplyField;
			}
			set
			{
				this.activeProfileReplyField = value;
			}
		}
		public string velocityInfoCode
		{
			get
			{
				return this.velocityInfoCodeField;
			}
			set
			{
				this.velocityInfoCodeField = value;
			}
		}
	}
}
