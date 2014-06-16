using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Pos
	{
		private string entryModeField;
		private string cardPresentField;
		private string terminalCapabilityField;
		private string trackDataField;
		private string terminalIDField;
		private string terminalTypeField;
		private string terminalLocationField;
		private string transactionSecurityField;
		private string catLevelField;
		private string conditionCodeField;
		public string entryMode
		{
			get
			{
				return this.entryModeField;
			}
			set
			{
				this.entryModeField = value;
			}
		}
		public string cardPresent
		{
			get
			{
				return this.cardPresentField;
			}
			set
			{
				this.cardPresentField = value;
			}
		}
		public string terminalCapability
		{
			get
			{
				return this.terminalCapabilityField;
			}
			set
			{
				this.terminalCapabilityField = value;
			}
		}
		public string trackData
		{
			get
			{
				return this.trackDataField;
			}
			set
			{
				this.trackDataField = value;
			}
		}
		public string terminalID
		{
			get
			{
				return this.terminalIDField;
			}
			set
			{
				this.terminalIDField = value;
			}
		}
		public string terminalType
		{
			get
			{
				return this.terminalTypeField;
			}
			set
			{
				this.terminalTypeField = value;
			}
		}
		public string terminalLocation
		{
			get
			{
				return this.terminalLocationField;
			}
			set
			{
				this.terminalLocationField = value;
			}
		}
		public string transactionSecurity
		{
			get
			{
				return this.transactionSecurityField;
			}
			set
			{
				this.transactionSecurityField = value;
			}
		}
		public string catLevel
		{
			get
			{
				return this.catLevelField;
			}
			set
			{
				this.catLevelField = value;
			}
		}
		public string conditionCode
		{
			get
			{
				return this.conditionCodeField;
			}
			set
			{
				this.conditionCodeField = value;
			}
		}
	}
}
