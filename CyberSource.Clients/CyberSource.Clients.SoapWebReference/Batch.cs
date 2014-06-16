using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Batch
	{
		private string batchIDField;
		private string recordIDField;
		public string batchID
		{
			get
			{
				return this.batchIDField;
			}
			set
			{
				this.batchIDField = value;
			}
		}
		public string recordID
		{
			get
			{
				return this.recordIDField;
			}
			set
			{
				this.recordIDField = value;
			}
		}
	}
}
