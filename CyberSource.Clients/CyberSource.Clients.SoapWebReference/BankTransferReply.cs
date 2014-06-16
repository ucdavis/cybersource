using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BankTransferReply
	{
		private string reasonCodeField;
		private string accountHolderField;
		private string accountNumberField;
		private string amountField;
		private string bankNameField;
		private string bankCityField;
		private string bankCountryField;
		private string paymentReferenceField;
		private string processorResponseField;
		private string bankSwiftCodeField;
		private string bankSpecialIDField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string ibanField;
		private string bankCodeField;
		private string branchCodeField;
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
		public string accountHolder
		{
			get
			{
				return this.accountHolderField;
			}
			set
			{
				this.accountHolderField = value;
			}
		}
		public string accountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.accountNumberField = value;
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
		public string bankName
		{
			get
			{
				return this.bankNameField;
			}
			set
			{
				this.bankNameField = value;
			}
		}
		public string bankCity
		{
			get
			{
				return this.bankCityField;
			}
			set
			{
				this.bankCityField = value;
			}
		}
		public string bankCountry
		{
			get
			{
				return this.bankCountryField;
			}
			set
			{
				this.bankCountryField = value;
			}
		}
		public string paymentReference
		{
			get
			{
				return this.paymentReferenceField;
			}
			set
			{
				this.paymentReferenceField = value;
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
		public string bankSwiftCode
		{
			get
			{
				return this.bankSwiftCodeField;
			}
			set
			{
				this.bankSwiftCodeField = value;
			}
		}
		public string bankSpecialID
		{
			get
			{
				return this.bankSpecialIDField;
			}
			set
			{
				this.bankSpecialIDField = value;
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
		public string iban
		{
			get
			{
				return this.ibanField;
			}
			set
			{
				this.ibanField = value;
			}
		}
		public string bankCode
		{
			get
			{
				return this.bankCodeField;
			}
			set
			{
				this.bankCodeField = value;
			}
		}
		public string branchCode
		{
			get
			{
				return this.branchCodeField;
			}
			set
			{
				this.branchCodeField = value;
			}
		}
	}
}
