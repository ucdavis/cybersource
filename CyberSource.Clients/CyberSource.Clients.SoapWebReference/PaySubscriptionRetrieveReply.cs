using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PaySubscriptionRetrieveReply
	{
		private string reasonCodeField;
		private string approvalRequiredField;
		private string automaticRenewField;
		private string cardAccountNumberField;
		private string cardExpirationMonthField;
		private string cardExpirationYearField;
		private string cardIssueNumberField;
		private string cardStartMonthField;
		private string cardStartYearField;
		private string cardTypeField;
		private string checkAccountNumberField;
		private string checkAccountTypeField;
		private string checkBankTransitNumberField;
		private string cityField;
		private string commentsField;
		private string companyNameField;
		private string countryField;
		private string currencyField;
		private string customerAccountIDField;
		private string emailField;
		private string endDateField;
		private string firstNameField;
		private string frequencyField;
		private string lastNameField;
		private string merchantReferenceCodeField;
		private string paymentMethodField;
		private string paymentsRemainingField;
		private string phoneNumberField;
		private string postalCodeField;
		private string recurringAmountField;
		private string setupAmountField;
		private string startDateField;
		private string stateField;
		private string statusField;
		private string street1Field;
		private string street2Field;
		private string subscriptionIDField;
		private string titleField;
		private string totalPaymentsField;
		private string shipToFirstNameField;
		private string shipToLastNameField;
		private string shipToStreet1Field;
		private string shipToStreet2Field;
		private string shipToCityField;
		private string shipToStateField;
		private string shipToPostalCodeField;
		private string shipToCompanyField;
		private string shipToCountryField;
		private string billPaymentField;
		private string merchantDefinedDataField1Field;
		private string merchantDefinedDataField2Field;
		private string merchantDefinedDataField3Field;
		private string merchantDefinedDataField4Field;
		private string merchantSecureDataField1Field;
		private string merchantSecureDataField2Field;
		private string merchantSecureDataField3Field;
		private string merchantSecureDataField4Field;
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
		public string approvalRequired
		{
			get
			{
				return this.approvalRequiredField;
			}
			set
			{
				this.approvalRequiredField = value;
			}
		}
		public string automaticRenew
		{
			get
			{
				return this.automaticRenewField;
			}
			set
			{
				this.automaticRenewField = value;
			}
		}
		public string cardAccountNumber
		{
			get
			{
				return this.cardAccountNumberField;
			}
			set
			{
				this.cardAccountNumberField = value;
			}
		}
		public string cardExpirationMonth
		{
			get
			{
				return this.cardExpirationMonthField;
			}
			set
			{
				this.cardExpirationMonthField = value;
			}
		}
		public string cardExpirationYear
		{
			get
			{
				return this.cardExpirationYearField;
			}
			set
			{
				this.cardExpirationYearField = value;
			}
		}
		public string cardIssueNumber
		{
			get
			{
				return this.cardIssueNumberField;
			}
			set
			{
				this.cardIssueNumberField = value;
			}
		}
		public string cardStartMonth
		{
			get
			{
				return this.cardStartMonthField;
			}
			set
			{
				this.cardStartMonthField = value;
			}
		}
		public string cardStartYear
		{
			get
			{
				return this.cardStartYearField;
			}
			set
			{
				this.cardStartYearField = value;
			}
		}
		public string cardType
		{
			get
			{
				return this.cardTypeField;
			}
			set
			{
				this.cardTypeField = value;
			}
		}
		public string checkAccountNumber
		{
			get
			{
				return this.checkAccountNumberField;
			}
			set
			{
				this.checkAccountNumberField = value;
			}
		}
		public string checkAccountType
		{
			get
			{
				return this.checkAccountTypeField;
			}
			set
			{
				this.checkAccountTypeField = value;
			}
		}
		public string checkBankTransitNumber
		{
			get
			{
				return this.checkBankTransitNumberField;
			}
			set
			{
				this.checkBankTransitNumberField = value;
			}
		}
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		public string comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}
		public string companyName
		{
			get
			{
				return this.companyNameField;
			}
			set
			{
				this.companyNameField = value;
			}
		}
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}
		public string currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
		public string customerAccountID
		{
			get
			{
				return this.customerAccountIDField;
			}
			set
			{
				this.customerAccountIDField = value;
			}
		}
		public string email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
			}
		}
		public string endDate
		{
			get
			{
				return this.endDateField;
			}
			set
			{
				this.endDateField = value;
			}
		}
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		public string frequency
		{
			get
			{
				return this.frequencyField;
			}
			set
			{
				this.frequencyField = value;
			}
		}
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		public string merchantReferenceCode
		{
			get
			{
				return this.merchantReferenceCodeField;
			}
			set
			{
				this.merchantReferenceCodeField = value;
			}
		}
		public string paymentMethod
		{
			get
			{
				return this.paymentMethodField;
			}
			set
			{
				this.paymentMethodField = value;
			}
		}
		public string paymentsRemaining
		{
			get
			{
				return this.paymentsRemainingField;
			}
			set
			{
				this.paymentsRemainingField = value;
			}
		}
		public string phoneNumber
		{
			get
			{
				return this.phoneNumberField;
			}
			set
			{
				this.phoneNumberField = value;
			}
		}
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		public string recurringAmount
		{
			get
			{
				return this.recurringAmountField;
			}
			set
			{
				this.recurringAmountField = value;
			}
		}
		public string setupAmount
		{
			get
			{
				return this.setupAmountField;
			}
			set
			{
				this.setupAmountField = value;
			}
		}
		public string startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		public string street1
		{
			get
			{
				return this.street1Field;
			}
			set
			{
				this.street1Field = value;
			}
		}
		public string street2
		{
			get
			{
				return this.street2Field;
			}
			set
			{
				this.street2Field = value;
			}
		}
		public string subscriptionID
		{
			get
			{
				return this.subscriptionIDField;
			}
			set
			{
				this.subscriptionIDField = value;
			}
		}
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}
		public string totalPayments
		{
			get
			{
				return this.totalPaymentsField;
			}
			set
			{
				this.totalPaymentsField = value;
			}
		}
		public string shipToFirstName
		{
			get
			{
				return this.shipToFirstNameField;
			}
			set
			{
				this.shipToFirstNameField = value;
			}
		}
		public string shipToLastName
		{
			get
			{
				return this.shipToLastNameField;
			}
			set
			{
				this.shipToLastNameField = value;
			}
		}
		public string shipToStreet1
		{
			get
			{
				return this.shipToStreet1Field;
			}
			set
			{
				this.shipToStreet1Field = value;
			}
		}
		public string shipToStreet2
		{
			get
			{
				return this.shipToStreet2Field;
			}
			set
			{
				this.shipToStreet2Field = value;
			}
		}
		public string shipToCity
		{
			get
			{
				return this.shipToCityField;
			}
			set
			{
				this.shipToCityField = value;
			}
		}
		public string shipToState
		{
			get
			{
				return this.shipToStateField;
			}
			set
			{
				this.shipToStateField = value;
			}
		}
		public string shipToPostalCode
		{
			get
			{
				return this.shipToPostalCodeField;
			}
			set
			{
				this.shipToPostalCodeField = value;
			}
		}
		public string shipToCompany
		{
			get
			{
				return this.shipToCompanyField;
			}
			set
			{
				this.shipToCompanyField = value;
			}
		}
		public string shipToCountry
		{
			get
			{
				return this.shipToCountryField;
			}
			set
			{
				this.shipToCountryField = value;
			}
		}
		public string billPayment
		{
			get
			{
				return this.billPaymentField;
			}
			set
			{
				this.billPaymentField = value;
			}
		}
		public string merchantDefinedDataField1
		{
			get
			{
				return this.merchantDefinedDataField1Field;
			}
			set
			{
				this.merchantDefinedDataField1Field = value;
			}
		}
		public string merchantDefinedDataField2
		{
			get
			{
				return this.merchantDefinedDataField2Field;
			}
			set
			{
				this.merchantDefinedDataField2Field = value;
			}
		}
		public string merchantDefinedDataField3
		{
			get
			{
				return this.merchantDefinedDataField3Field;
			}
			set
			{
				this.merchantDefinedDataField3Field = value;
			}
		}
		public string merchantDefinedDataField4
		{
			get
			{
				return this.merchantDefinedDataField4Field;
			}
			set
			{
				this.merchantDefinedDataField4Field = value;
			}
		}
		public string merchantSecureDataField1
		{
			get
			{
				return this.merchantSecureDataField1Field;
			}
			set
			{
				this.merchantSecureDataField1Field = value;
			}
		}
		public string merchantSecureDataField2
		{
			get
			{
				return this.merchantSecureDataField2Field;
			}
			set
			{
				this.merchantSecureDataField2Field = value;
			}
		}
		public string merchantSecureDataField3
		{
			get
			{
				return this.merchantSecureDataField3Field;
			}
			set
			{
				this.merchantSecureDataField3Field = value;
			}
		}
		public string merchantSecureDataField4
		{
			get
			{
				return this.merchantSecureDataField4Field;
			}
			set
			{
				this.merchantSecureDataField4Field = value;
			}
		}
	}
}
