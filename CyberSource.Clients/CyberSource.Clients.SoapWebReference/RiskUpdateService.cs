using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class RiskUpdateService
	{
		private string actionCodeField;
		private string recordIDField;
		private string recordNameField;
		private Address negativeAddressField;
		private string runField;
		public string actionCode
		{
			get
			{
				return this.actionCodeField;
			}
			set
			{
				this.actionCodeField = value;
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
		public string recordName
		{
			get
			{
				return this.recordNameField;
			}
			set
			{
				this.recordNameField = value;
			}
		}
		public Address negativeAddress
		{
			get
			{
				return this.negativeAddressField;
			}
			set
			{
				this.negativeAddressField = value;
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
