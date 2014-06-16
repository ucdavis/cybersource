using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayerAuthEnrollReply
	{
		private string reasonCodeField;
		private string acsURLField;
		private string commerceIndicatorField;
		private string paReqField;
		private string proxyPANField;
		private string xidField;
		private string proofXMLField;
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
		public string acsURL
		{
			get
			{
				return this.acsURLField;
			}
			set
			{
				this.acsURLField = value;
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
		public string paReq
		{
			get
			{
				return this.paReqField;
			}
			set
			{
				this.paReqField = value;
			}
		}
		public string proxyPAN
		{
			get
			{
				return this.proxyPANField;
			}
			set
			{
				this.proxyPANField = value;
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
		public string proofXML
		{
			get
			{
				return this.proofXMLField;
			}
			set
			{
				this.proofXMLField = value;
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
