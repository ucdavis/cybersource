using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayerAuthValidateReply
	{
		private string reasonCodeField;
		private string authenticationResultField;
		private string authenticationStatusMessageField;
		private string cavvField;
		private string commerceIndicatorField;
		private string eciField;
		private string eciRawField;
		private string xidField;
		private string ucafAuthenticationDataField;
		private string ucafCollectionIndicatorField;
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
		public string authenticationResult
		{
			get
			{
				return this.authenticationResultField;
			}
			set
			{
				this.authenticationResultField = value;
			}
		}
		public string authenticationStatusMessage
		{
			get
			{
				return this.authenticationStatusMessageField;
			}
			set
			{
				this.authenticationStatusMessageField = value;
			}
		}
		public string cavv
		{
			get
			{
				return this.cavvField;
			}
			set
			{
				this.cavvField = value;
			}
		}
		public string commerceIndicator
		{
			get
			{
				return this.commerceIndicatorField;
			}
			set
			{
				this.commerceIndicatorField = value;
			}
		}
		public string eci
		{
			get
			{
				return this.eciField;
			}
			set
			{
				this.eciField = value;
			}
		}
		public string eciRaw
		{
			get
			{
				return this.eciRawField;
			}
			set
			{
				this.eciRawField = value;
			}
		}
		public string xid
		{
			get
			{
				return this.xidField;
			}
			set
			{
				this.xidField = value;
			}
		}
		public string ucafAuthenticationData
		{
			get
			{
				return this.ucafAuthenticationDataField;
			}
			set
			{
				this.ucafAuthenticationDataField = value;
			}
		}
		public string ucafCollectionIndicator
		{
			get
			{
				return this.ucafCollectionIndicatorField;
			}
			set
			{
				this.ucafCollectionIndicatorField = value;
			}
		}
	}
}
