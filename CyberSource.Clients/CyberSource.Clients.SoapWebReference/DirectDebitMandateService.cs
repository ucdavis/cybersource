using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DirectDebitMandateService
	{
		private string mandateDescriptorField;
		private string firstDebitDateField;
		private string runField;
		public string mandateDescriptor
		{
			get
			{
				return this.mandateDescriptorField;
			}
			set
			{
				this.mandateDescriptorField = value;
			}
		}
		public string firstDebitDate
		{
			get
			{
				return this.firstDebitDateField;
			}
			set
			{
				this.firstDebitDateField = value;
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
