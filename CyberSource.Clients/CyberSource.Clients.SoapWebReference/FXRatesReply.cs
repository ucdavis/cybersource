using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class FXRatesReply
	{
		private string reasonCodeField;
		private FXQuote[] quoteField;
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
		[XmlElement("quote")]
		public FXQuote[] quote
		{
			get
			{
				return this.quoteField;
			}
			set
			{
				this.quoteField = value;
			}
		}
	}
}
