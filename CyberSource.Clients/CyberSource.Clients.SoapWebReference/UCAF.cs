using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class UCAF
	{
		private string authenticationDataField;
		private string collectionIndicatorField;
		public string authenticationData
		{
			get
			{
				return this.authenticationDataField;
			}
			set
			{
				this.authenticationDataField = value;
			}
		}
		public string collectionIndicator
		{
			get
			{
				return this.collectionIndicatorField;
			}
			set
			{
				this.collectionIndicatorField = value;
			}
		}
	}
}
