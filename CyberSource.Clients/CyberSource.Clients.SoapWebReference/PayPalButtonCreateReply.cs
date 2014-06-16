using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayPalButtonCreateReply
	{
		private string reasonCodeField;
		private string encryptedFormDataField;
		private string unencryptedFormDataField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string buttonTypeField;
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
		public string encryptedFormData
		{
			get
			{
				return this.encryptedFormDataField;
			}
			set
			{
				this.encryptedFormDataField = value;
			}
		}
		public string unencryptedFormData
		{
			get
			{
				return this.unencryptedFormDataField;
			}
			set
			{
				this.unencryptedFormDataField = value;
			}
		}
		public string requestDateTime
		{
			get
			{
				return this.requestDateTimeField;
			}
			set
			{
				this.requestDateTimeField = value;
			}
		}
		public string reconciliationID
		{
			get
			{
				return this.reconciliationIDField;
			}
			set
			{
				this.reconciliationIDField = value;
			}
		}
		public string buttonType
		{
			get
			{
				return this.buttonTypeField;
			}
			set
			{
				this.buttonTypeField = value;
			}
		}
	}
}
