using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BillTo
	{
		private string titleField;
		private string firstNameField;
		private string middleNameField;
		private string lastNameField;
		private string suffixField;
		private string street1Field;
		private string street2Field;
		private string street3Field;
		private string street4Field;
		private string cityField;
		private string countyField;
		private string stateField;
		private string postalCodeField;
		private string countryField;
		private string companyField;
		private string companyTaxIDField;
		private string phoneNumberField;
		private string emailField;
		private string ipAddressField;
		private string ipNetworkAddressField;
		private string hostnameField;
		private string domainNameField;
		private string dateOfBirthField;
		private string driversLicenseNumberField;
		private string driversLicenseStateField;
		private string ssnField;
		private string customerIDField;
		private string httpBrowserTypeField;
		private string httpBrowserEmailField;
		private string httpBrowserCookiesAcceptedField;
		private string nifField;
		private string personalIDField;
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
		public string middleName
		{
			get
			{
				return this.middleNameField;
			}
			set
			{
				this.middleNameField = value;
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
		public string suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
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
		public string street3
		{
			get
			{
				return this.street3Field;
			}
			set
			{
				this.street3Field = value;
			}
		}
		public string street4
		{
			get
			{
				return this.street4Field;
			}
			set
			{
				this.street4Field = value;
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
		public string county
		{
			get
			{
				return this.countyField;
			}
			set
			{
				this.countyField = value;
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
		public string company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
			}
		}
		public string companyTaxID
		{
			get
			{
				return this.companyTaxIDField;
			}
			set
			{
				this.companyTaxIDField = value;
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
		public string ipAddress
		{
			get
			{
				return this.ipAddressField;
			}
			set
			{
				this.ipAddressField = value;
			}
		}
		public string ipNetworkAddress
		{
			get
			{
				return this.ipNetworkAddressField;
			}
			set
			{
				this.ipNetworkAddressField = value;
			}
		}
		public string hostname
		{
			get
			{
				return this.hostnameField;
			}
			set
			{
				this.hostnameField = value;
			}
		}
		public string domainName
		{
			get
			{
				return this.domainNameField;
			}
			set
			{
				this.domainNameField = value;
			}
		}
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		public string driversLicenseNumber
		{
			get
			{
				return this.driversLicenseNumberField;
			}
			set
			{
				this.driversLicenseNumberField = value;
			}
		}
		public string driversLicenseState
		{
			get
			{
				return this.driversLicenseStateField;
			}
			set
			{
				this.driversLicenseStateField = value;
			}
		}
		public string ssn
		{
			get
			{
				return this.ssnField;
			}
			set
			{
				this.ssnField = value;
			}
		}
		public string customerID
		{
			get
			{
				return this.customerIDField;
			}
			set
			{
				this.customerIDField = value;
			}
		}
		public string httpBrowserType
		{
			get
			{
				return this.httpBrowserTypeField;
			}
			set
			{
				this.httpBrowserTypeField = value;
			}
		}
		public string httpBrowserEmail
		{
			get
			{
				return this.httpBrowserEmailField;
			}
			set
			{
				this.httpBrowserEmailField = value;
			}
		}
		public string httpBrowserCookiesAccepted
		{
			get
			{
				return this.httpBrowserCookiesAcceptedField;
			}
			set
			{
				this.httpBrowserCookiesAcceptedField = value;
			}
		}
		public string nif
		{
			get
			{
				return this.nifField;
			}
			set
			{
				this.nifField = value;
			}
		}
		public string personalID
		{
			get
			{
				return this.personalIDField;
			}
			set
			{
				this.personalIDField = value;
			}
		}
	}
}
