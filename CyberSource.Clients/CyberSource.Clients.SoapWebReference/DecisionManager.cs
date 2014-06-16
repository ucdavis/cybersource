using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DecisionManager
	{
		private string enabledField;
		private string profileField;
		public string enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				this.enabledField = value;
			}
		}
		public string profile
		{
			get
			{
				return this.profileField;
			}
			set
			{
				this.profileField = value;
			}
		}
	}
}
