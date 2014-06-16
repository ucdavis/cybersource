using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayPalPreapprovedPaymentReply
	{
		private string reasonCodeField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string payerStatusField;
		private string payerNameField;
		private string transactionTypeField;
		private string feeAmountField;
		private string payerCountryField;
		private string pendingReasonField;
		private string paymentStatusField;
		private string mpStatusField;
		private string payerField;
		private string payerIDField;
		private string payerBusinessField;
		private string transactionIDField;
		private string descField;
		private string mpMaxField;
		private string paymentTypeField;
		private string paymentDateField;
		private string paymentGrossAmountField;
		private string settleAmountField;
		private string taxAmountField;
		private string exchangeRateField;
		private string paymentSourceIDField;
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
		public string payerStatus
		{
			get
			{
				return this.payerStatusField;
			}
			set
			{
				this.payerStatusField = value;
			}
		}
		public string payerName
		{
			get
			{
				return this.payerNameField;
			}
			set
			{
				this.payerNameField = value;
			}
		}
		public string transactionType
		{
			get
			{
				return this.transactionTypeField;
			}
			set
			{
				this.transactionTypeField = value;
			}
		}
		public string feeAmount
		{
			get
			{
				return this.feeAmountField;
			}
			set
			{
				this.feeAmountField = value;
			}
		}
		public string payerCountry
		{
			get
			{
				return this.payerCountryField;
			}
			set
			{
				this.payerCountryField = value;
			}
		}
		public string pendingReason
		{
			get
			{
				return this.pendingReasonField;
			}
			set
			{
				this.pendingReasonField = value;
			}
		}
		public string paymentStatus
		{
			get
			{
				return this.paymentStatusField;
			}
			set
			{
				this.paymentStatusField = value;
			}
		}
		public string mpStatus
		{
			get
			{
				return this.mpStatusField;
			}
			set
			{
				this.mpStatusField = value;
			}
		}
		public string payer
		{
			get
			{
				return this.payerField;
			}
			set
			{
				this.payerField = value;
			}
		}
		public string payerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		public string payerBusiness
		{
			get
			{
				return this.payerBusinessField;
			}
			set
			{
				this.payerBusinessField = value;
			}
		}
		public string transactionID
		{
			get
			{
				return this.transactionIDField;
			}
			set
			{
				this.transactionIDField = value;
			}
		}
		public string desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}
		public string mpMax
		{
			get
			{
				return this.mpMaxField;
			}
			set
			{
				this.mpMaxField = value;
			}
		}
		public string paymentType
		{
			get
			{
				return this.paymentTypeField;
			}
			set
			{
				this.paymentTypeField = value;
			}
		}
		public string paymentDate
		{
			get
			{
				return this.paymentDateField;
			}
			set
			{
				this.paymentDateField = value;
			}
		}
		public string paymentGrossAmount
		{
			get
			{
				return this.paymentGrossAmountField;
			}
			set
			{
				this.paymentGrossAmountField = value;
			}
		}
		public string settleAmount
		{
			get
			{
				return this.settleAmountField;
			}
			set
			{
				this.settleAmountField = value;
			}
		}
		public string taxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		public string exchangeRate
		{
			get
			{
				return this.exchangeRateField;
			}
			set
			{
				this.exchangeRateField = value;
			}
		}
		public string paymentSourceID
		{
			get
			{
				return this.paymentSourceIDField;
			}
			set
			{
				this.paymentSourceIDField = value;
			}
		}
	}
}
