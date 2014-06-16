using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCCreditReply
	{
		private string reasonCodeField;
		private string requestDateTimeField;
		private string amountField;
		private string reconciliationIDField;
		private string purchasingLevel3EnabledField;
		private string enhancedDataEnabledField;
		private string authorizationXIDField;
		private string forwardCodeField;
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
		public string amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
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
		public string purchasingLevel3Enabled
		{
			get
			{
				return this.purchasingLevel3EnabledField;
			}
			set
			{
				this.purchasingLevel3EnabledField = value;
			}
		}
		public string enhancedDataEnabled
		{
			get
			{
				return this.enhancedDataEnabledField;
			}
			set
			{
				this.enhancedDataEnabledField = value;
			}
		}
		public string authorizationXID
		{
			get
			{
				return this.authorizationXIDField;
			}
			set
			{
				this.authorizationXIDField = value;
			}
		}
		public string forwardCode
		{
			get
			{
				return this.forwardCodeField;
			}
			set
			{
				this.forwardCodeField = value;
			}
		}
	}
}
