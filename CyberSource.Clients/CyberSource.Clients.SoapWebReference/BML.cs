using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BML
	{
		private string customerBillingAddressChangeField;
		private string customerEmailChangeField;
		private string customerHasCheckingAccountField;
		private string customerHasSavingsAccountField;
		private string customerPasswordChangeField;
		private string customerPhoneChangeField;
		private string customerRegistrationDateField;
		private string customerTypeFlagField;
		private string grossHouseholdIncomeField;
		private string householdIncomeCurrencyField;
		private string itemCategoryField;
		private string merchantPromotionCodeField;
		private string preapprovalNumberField;
		private string productDeliveryTypeIndicatorField;
		private string residenceStatusField;
		private string tcVersionField;
		private string yearsAtCurrentResidenceField;
		private string yearsWithCurrentEmployerField;
		private string employerStreet1Field;
		private string employerStreet2Field;
		private string employerCityField;
		private string employerCompanyNameField;
		private string employerCountryField;
		private string employerPhoneNumberField;
		private string employerPhoneTypeField;
		private string employerStateField;
		private string employerPostalCodeField;
		private string shipToPhoneTypeField;
		private string billToPhoneTypeField;
		public string customerBillingAddressChange
		{
			get
			{
				return this.customerBillingAddressChangeField;
			}
			set
			{
				this.customerBillingAddressChangeField = value;
			}
		}
		public string customerEmailChange
		{
			get
			{
				return this.customerEmailChangeField;
			}
			set
			{
				this.customerEmailChangeField = value;
			}
		}
		public string customerHasCheckingAccount
		{
			get
			{
				return this.customerHasCheckingAccountField;
			}
			set
			{
				this.customerHasCheckingAccountField = value;
			}
		}
		public string customerHasSavingsAccount
		{
			get
			{
				return this.customerHasSavingsAccountField;
			}
			set
			{
				this.customerHasSavingsAccountField = value;
			}
		}
		public string customerPasswordChange
		{
			get
			{
				return this.customerPasswordChangeField;
			}
			set
			{
				this.customerPasswordChangeField = value;
			}
		}
		public string customerPhoneChange
		{
			get
			{
				return this.customerPhoneChangeField;
			}
			set
			{
				this.customerPhoneChangeField = value;
			}
		}
		public string customerRegistrationDate
		{
			get
			{
				return this.customerRegistrationDateField;
			}
			set
			{
				this.customerRegistrationDateField = value;
			}
		}
		public string customerTypeFlag
		{
			get
			{
				return this.customerTypeFlagField;
			}
			set
			{
				this.customerTypeFlagField = value;
			}
		}
		public string grossHouseholdIncome
		{
			get
			{
				return this.grossHouseholdIncomeField;
			}
			set
			{
				this.grossHouseholdIncomeField = value;
			}
		}
		public string householdIncomeCurrency
		{
			get
			{
				return this.householdIncomeCurrencyField;
			}
			set
			{
				this.householdIncomeCurrencyField = value;
			}
		}
		public string itemCategory
		{
			get
			{
				return this.itemCategoryField;
			}
			set
			{
				this.itemCategoryField = value;
			}
		}
		public string merchantPromotionCode
		{
			get
			{
				return this.merchantPromotionCodeField;
			}
			set
			{
				this.merchantPromotionCodeField = value;
			}
		}
		public string preapprovalNumber
		{
			get
			{
				return this.preapprovalNumberField;
			}
			set
			{
				this.preapprovalNumberField = value;
			}
		}
		public string productDeliveryTypeIndicator
		{
			get
			{
				return this.productDeliveryTypeIndicatorField;
			}
			set
			{
				this.productDeliveryTypeIndicatorField = value;
			}
		}
		public string residenceStatus
		{
			get
			{
				return this.residenceStatusField;
			}
			set
			{
				this.residenceStatusField = value;
			}
		}
		public string tcVersion
		{
			get
			{
				return this.tcVersionField;
			}
			set
			{
				this.tcVersionField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string yearsAtCurrentResidence
		{
			get
			{
				return this.yearsAtCurrentResidenceField;
			}
			set
			{
				this.yearsAtCurrentResidenceField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string yearsWithCurrentEmployer
		{
			get
			{
				return this.yearsWithCurrentEmployerField;
			}
			set
			{
				this.yearsWithCurrentEmployerField = value;
			}
		}
		public string employerStreet1
		{
			get
			{
				return this.employerStreet1Field;
			}
			set
			{
				this.employerStreet1Field = value;
			}
		}
		public string employerStreet2
		{
			get
			{
				return this.employerStreet2Field;
			}
			set
			{
				this.employerStreet2Field = value;
			}
		}
		public string employerCity
		{
			get
			{
				return this.employerCityField;
			}
			set
			{
				this.employerCityField = value;
			}
		}
		public string employerCompanyName
		{
			get
			{
				return this.employerCompanyNameField;
			}
			set
			{
				this.employerCompanyNameField = value;
			}
		}
		public string employerCountry
		{
			get
			{
				return this.employerCountryField;
			}
			set
			{
				this.employerCountryField = value;
			}
		}
		public string employerPhoneNumber
		{
			get
			{
				return this.employerPhoneNumberField;
			}
			set
			{
				this.employerPhoneNumberField = value;
			}
		}
		public string employerPhoneType
		{
			get
			{
				return this.employerPhoneTypeField;
			}
			set
			{
				this.employerPhoneTypeField = value;
			}
		}
		public string employerState
		{
			get
			{
				return this.employerStateField;
			}
			set
			{
				this.employerStateField = value;
			}
		}
		public string employerPostalCode
		{
			get
			{
				return this.employerPostalCodeField;
			}
			set
			{
				this.employerPostalCodeField = value;
			}
		}
		public string shipToPhoneType
		{
			get
			{
				return this.shipToPhoneTypeField;
			}
			set
			{
				this.shipToPhoneTypeField = value;
			}
		}
		public string billToPhoneType
		{
			get
			{
				return this.billToPhoneTypeField;
			}
			set
			{
				this.billToPhoneTypeField = value;
			}
		}
	}
}
