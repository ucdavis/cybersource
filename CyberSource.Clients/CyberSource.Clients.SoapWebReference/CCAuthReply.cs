using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCAuthReply
	{
		private string reasonCodeField;
		private string amountField;
		private string authorizationCodeField;
		private string avsCodeField;
		private string avsCodeRawField;
		private string cvCodeField;
		private string cvCodeRawField;
		private string personalIDCodeField;
		private string authorizedDateTimeField;
		private string processorResponseField;
		private string bmlAccountNumberField;
		private string authFactorCodeField;
		private string reconciliationIDField;
		private FundingTotals fundingTotalsField;
		private string fxQuoteIDField;
		private string fxQuoteRateField;
		private string fxQuoteTypeField;
		private string fxQuoteExpirationDateTimeField;
		private string authRecordField;
		private string merchantAdviceCodeField;
		private string merchantAdviceCodeRawField;
		private string cavvResponseCodeField;
		private string cavvResponseCodeRawField;
		private string authenticationXIDField;
		private string authorizationXIDField;
		private string processorCardTypeField;
		private string accountBalanceField;
		private string forwardCodeField;
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
		public string authorizationCode
		{
			get
			{
				return this.authorizationCodeField;
			}
			set
			{
				this.authorizationCodeField = value;
			}
		}
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
		public string avsCodeRaw
		{
			get
			{
				return this.avsCodeRawField;
			}
			set
			{
				this.avsCodeRawField = value;
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
		public string cvCodeRaw
		{
			get
			{
				return this.cvCodeRawField;
			}
			set
			{
				this.cvCodeRawField = value;
			}
		}
		public string personalIDCode
		{
			get
			{
				return this.personalIDCodeField;
			}
			set
			{
				this.personalIDCodeField = value;
			}
		}
		public string authorizedDateTime
		{
			get
			{
				return this.authorizedDateTimeField;
			}
			set
			{
				this.authorizedDateTimeField = value;
			}
		}
		public string processorResponse
		{
			get
			{
				return this.processorResponseField;
			}
			set
			{
				this.processorResponseField = value;
			}
		}
		public string bmlAccountNumber
		{
			get
			{
				return this.bmlAccountNumberField;
			}
			set
			{
				this.bmlAccountNumberField = value;
			}
		}
		public string authFactorCode
		{
			get
			{
				return this.authFactorCodeField;
			}
			set
			{
				this.authFactorCodeField = value;
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
		public string authRecord
		{
			get
			{
				return this.authRecordField;
			}
			set
			{
				this.authRecordField = value;
			}
		}
		public string merchantAdviceCode
		{
			get
			{
				return this.merchantAdviceCodeField;
			}
			set
			{
				this.merchantAdviceCodeField = value;
			}
		}
		public string merchantAdviceCodeRaw
		{
			get
			{
				return this.merchantAdviceCodeRawField;
			}
			set
			{
				this.merchantAdviceCodeRawField = value;
			}
		}
		public string cavvResponseCode
		{
			get
			{
				return this.cavvResponseCodeField;
			}
			set
			{
				this.cavvResponseCodeField = value;
			}
		}
		public string cavvResponseCodeRaw
		{
			get
			{
				return this.cavvResponseCodeRawField;
			}
			set
			{
				this.cavvResponseCodeRawField = value;
			}
		}
		public string authenticationXID
		{
			get
			{
				return this.authenticationXIDField;
			}
			set
			{
				this.authenticationXIDField = value;
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
		public string processorCardType
		{
			get
			{
				return this.processorCardTypeField;
			}
			set
			{
				this.processorCardTypeField = value;
			}
		}
		public string accountBalance
		{
			get
			{
				return this.accountBalanceField;
			}
			set
			{
				this.accountBalanceField = value;
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
