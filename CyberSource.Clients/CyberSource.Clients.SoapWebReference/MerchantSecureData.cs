using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class MerchantSecureData
	{
		private string field1Field;
		private string field2Field;
		private string field3Field;
		private string field4Field;
		public string field1
		{
			get
			{
				return this.field1Field;
			}
			set
			{
				this.field1Field = value;
			}
		}
		public string field2
		{
			get
			{
				return this.field2Field;
			}
			set
			{
				this.field2Field = value;
			}
		}
		public string field3
		{
			get
			{
				return this.field3Field;
			}
			set
			{
				this.field3Field = value;
			}
		}
		public string field4
		{
			get
			{
				return this.field4Field;
			}
			set
			{
				this.field4Field = value;
			}
		}
	}
}
