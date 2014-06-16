using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BusinessRules
	{
		private string ignoreAVSResultField;
		private string ignoreCVResultField;
		private string ignoreDAVResultField;
		private string ignoreExportResultField;
		private string ignoreValidateResultField;
		private string declineAVSFlagsField;
		private string scoreThresholdField;
		public string ignoreAVSResult
		{
			get
			{
				return this.ignoreAVSResultField;
			}
			set
			{
				this.ignoreAVSResultField = value;
			}
		}
		public string ignoreCVResult
		{
			get
			{
				return this.ignoreCVResultField;
			}
			set
			{
				this.ignoreCVResultField = value;
			}
		}
		public string ignoreDAVResult
		{
			get
			{
				return this.ignoreDAVResultField;
			}
			set
			{
				this.ignoreDAVResultField = value;
			}
		}
		public string ignoreExportResult
		{
			get
			{
				return this.ignoreExportResultField;
			}
			set
			{
				this.ignoreExportResultField = value;
			}
		}
		public string ignoreValidateResult
		{
			get
			{
				return this.ignoreValidateResultField;
			}
			set
			{
				this.ignoreValidateResultField = value;
			}
		}
		public string declineAVSFlags
		{
			get
			{
				return this.declineAVSFlagsField;
			}
			set
			{
				this.declineAVSFlagsField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string scoreThreshold
		{
			get
			{
				return this.scoreThresholdField;
			}
			set
			{
				this.scoreThresholdField = value;
			}
		}
	}
}
