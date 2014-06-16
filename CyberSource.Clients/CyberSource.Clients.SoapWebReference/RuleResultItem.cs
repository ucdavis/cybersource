using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class RuleResultItem
	{
		private string nameField;
		private string decisionField;
		private string evaluationField;
		private string ruleIDField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string decision
		{
			get
			{
				return this.decisionField;
			}
			set
			{
				this.decisionField = value;
			}
		}
		public string evaluation
		{
			get
			{
				return this.evaluationField;
			}
			set
			{
				this.evaluationField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string ruleID
		{
			get
			{
				return this.ruleIDField;
			}
			set
			{
				this.ruleIDField = value;
			}
		}
	}
}
