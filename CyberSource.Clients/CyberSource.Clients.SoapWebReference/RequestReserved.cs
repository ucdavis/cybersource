using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class RequestReserved
	{
		private string nameField;
		private string valueField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}
}
