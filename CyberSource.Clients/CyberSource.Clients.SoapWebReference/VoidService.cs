using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class VoidService
	{
		private string voidRequestIDField;
		private string voidRequestTokenField;
		private string runField;
		public string voidRequestID
		{
			get
			{
				return this.voidRequestIDField;
			}
			set
			{
				this.voidRequestIDField = value;
			}
		}
		public string voidRequestToken
		{
			get
			{
				return this.voidRequestTokenField;
			}
			set
			{
				this.voidRequestTokenField = value;
			}
		}
		[XmlAttribute]
		public string run
		{
			get
			{
				return this.runField;
			}
			set
			{
				this.runField = value;
			}
		}
	}
}
