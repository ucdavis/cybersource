using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ExportService
	{
		private string addressOperatorField;
		private string addressWeightField;
		private string companyWeightField;
		private string nameWeightField;
		private string runField;
		public string addressOperator
		{
			get
			{
				return this.addressOperatorField;
			}
			set
			{
				this.addressOperatorField = value;
			}
		}
		public string addressWeight
		{
			get
			{
				return this.addressWeightField;
			}
			set
			{
				this.addressWeightField = value;
			}
		}
		public string companyWeight
		{
			get
			{
				return this.companyWeightField;
			}
			set
			{
				this.companyWeightField = value;
			}
		}
		public string nameWeight
		{
			get
			{
				return this.nameWeightField;
			}
			set
			{
				this.nameWeightField = value;
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
