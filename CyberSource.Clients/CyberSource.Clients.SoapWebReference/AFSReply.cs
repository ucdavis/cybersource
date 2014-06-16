using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class AFSReply
	{
		private string reasonCodeField;
		private string afsResultField;
		private string hostSeverityField;
		private string consumerLocalTimeField;
		private string afsFactorCodeField;
		private string addressInfoCodeField;
		private string hotlistInfoCodeField;
		private string internetInfoCodeField;
		private string phoneInfoCodeField;
		private string suspiciousInfoCodeField;
		private string velocityInfoCodeField;
		private string ipCountryField;
		private string ipStateField;
		private string ipCityField;
		private string ipRoutingMethodField;
		private string scoreModelUsedField;
		[XmlElement(DataType = "integer")]
		public string reasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string afsResult
		{
			get
			{
				return this.afsResultField;
			}
			set
			{
				this.afsResultField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string hostSeverity
		{
			get
			{
				return this.hostSeverityField;
			}
			set
			{
				this.hostSeverityField = value;
			}
		}
		public string consumerLocalTime
		{
			get
			{
				return this.consumerLocalTimeField;
			}
			set
			{
				this.consumerLocalTimeField = value;
			}
		}
		public string afsFactorCode
		{
			get
			{
				return this.afsFactorCodeField;
			}
			set
			{
				this.afsFactorCodeField = value;
			}
		}
		public string addressInfoCode
		{
			get
			{
				return this.addressInfoCodeField;
			}
			set
			{
				this.addressInfoCodeField = value;
			}
		}
		public string hotlistInfoCode
		{
			get
			{
				return this.hotlistInfoCodeField;
			}
			set
			{
				this.hotlistInfoCodeField = value;
			}
		}
		public string internetInfoCode
		{
			get
			{
				return this.internetInfoCodeField;
			}
			set
			{
				this.internetInfoCodeField = value;
			}
		}
		public string phoneInfoCode
		{
			get
			{
				return this.phoneInfoCodeField;
			}
			set
			{
				this.phoneInfoCodeField = value;
			}
		}
		public string suspiciousInfoCode
		{
			get
			{
				return this.suspiciousInfoCodeField;
			}
			set
			{
				this.suspiciousInfoCodeField = value;
			}
		}
		public string velocityInfoCode
		{
			get
			{
				return this.velocityInfoCodeField;
			}
			set
			{
				this.velocityInfoCodeField = value;
			}
		}
		public string ipCountry
		{
			get
			{
				return this.ipCountryField;
			}
			set
			{
				this.ipCountryField = value;
			}
		}
		public string ipState
		{
			get
			{
				return this.ipStateField;
			}
			set
			{
				this.ipStateField = value;
			}
		}
		public string ipCity
		{
			get
			{
				return this.ipCityField;
			}
			set
			{
				this.ipCityField = value;
			}
		}
		public string ipRoutingMethod
		{
			get
			{
				return this.ipRoutingMethodField;
			}
			set
			{
				this.ipRoutingMethodField = value;
			}
		}
		public string scoreModelUsed
		{
			get
			{
				return this.scoreModelUsedField;
			}
			set
			{
				this.scoreModelUsedField = value;
			}
		}
	}
}
