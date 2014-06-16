using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class AFSService
	{
		private string avsCodeField;
		private string cvCodeField;
		private string disableAVSScoringField;
		private string customRiskModelField;
		private string runField;
		public string avsCode
		{
			get
			{
				return this.avsCodeField;
			}
			set
			{
				this.avsCodeField = value;
			}
		}
		public string cvCode
		{
			get
			{
				return this.cvCodeField;
			}
			set
			{
				this.cvCodeField = value;
			}
		}
		public string disableAVSScoring
		{
			get
			{
				return this.disableAVSScoringField;
			}
			set
			{
				this.disableAVSScoringField = value;
			}
		}
		public string customRiskModel
		{
			get
			{
				return this.customRiskModelField;
			}
			set
			{
				this.customRiskModelField = value;
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
