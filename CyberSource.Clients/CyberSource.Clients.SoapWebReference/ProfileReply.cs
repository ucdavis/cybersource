using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ProfileReply
	{
		private string selectedByField;
		private string nameField;
		private string destinationQueueField;
		private RuleResultItem[] rulesTriggeredField;
		public string selectedBy
		{
			get
			{
				return this.selectedByField;
			}
			set
			{
				this.selectedByField = value;
			}
		}
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
		public string destinationQueue
		{
			get
			{
				return this.destinationQueueField;
			}
			set
			{
				this.destinationQueueField = value;
			}
		}
		[XmlArrayItem("ruleResultItem", IsNullable = false)]
		public RuleResultItem[] rulesTriggered
		{
			get
			{
				return this.rulesTriggeredField;
			}
			set
			{
				this.rulesTriggeredField = value;
			}
		}
	}
}
