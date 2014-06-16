using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DeniedPartiesMatch
	{
		private string listField;
		private string[] nameField;
		private string[] addressField;
		public string list
		{
			get
			{
				return this.listField;
			}
			set
			{
				this.listField = value;
			}
		}
		[XmlElement("name")]
		public string[] name
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
		[XmlElement("address")]
		public string[] address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
	}
}
