using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCCaptureReply
	{
		private string reasonCodeField;
		private string requestDateTimeField;
		private string amountField;
		private string reconciliationIDField;
		private FundingTotals fundingTotalsField;
		private string fxQuoteIDField;
		private string fxQuoteRateField;
		private string fxQuoteTypeField;
		private string fxQuoteExpirationDateTimeField;
		private string purchasingLevel3EnabledField;
		private string enhancedDataEnabledField;
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
		public FundingTotals fundingTotals
		{
			get
			{
				return this.fundingTotalsField;
			}
			set
			{
				this.fundingTotalsField = value;
			}
		}
		public string fxQuoteID
		{
			get
			{
				return this.fxQuoteIDField;
			}
			set
			{
				this.fxQuoteIDField = value;
			}
		}
		public string fxQuoteRate
		{
			get
			{
				return this.fxQuoteRateField;
			}
			set
			{
				this.fxQuoteRateField = value;
			}
		}
		public string fxQuoteType
		{
			get
			{
				return this.fxQuoteTypeField;
			}
			set
			{
				this.fxQuoteTypeField = value;
			}
		}
		public string fxQuoteExpirationDateTime
		{
			get
			{
				return this.fxQuoteExpirationDateTimeField;
			}
			set
			{
				this.fxQuoteExpirationDateTimeField = value;
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
	}
}
