using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ExportReply
	{
		private string reasonCodeField;
		private string ipCountryConfidenceField;
		[XmlElement(DataType = "integer")]
		public string reasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string ipCountryConfidence
		{
			get
			{
				return this.ipCountryConfidenceField;
			}
			set
			{
				this.ipCountryConfidenceField = value;
			}
		}
	}
}
