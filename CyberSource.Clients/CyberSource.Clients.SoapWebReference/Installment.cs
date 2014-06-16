using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Installment
	{
		private string sequenceField;
		private string totalCountField;
		public string sequence
		{
			get
			{
				return this.sequenceField;
			}
			set
			{
				this.sequenceField = value;
			}
		}
		public string totalCount
		{
			get
			{
				return this.totalCountField;
			}
			set
			{
				this.totalCountField = value;
			}
		}
	}
}
