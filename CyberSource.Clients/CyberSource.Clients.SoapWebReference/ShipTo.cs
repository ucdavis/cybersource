using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ShipTo
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
		private string phoneNumberField;
		private string emailField;
		private string shippingMethodField;
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
		public string shippingMethod
		{
			get
			{
				return this.shippingMethodField;
			}
			set
			{
				this.shippingMethodField = value;
			}
		}
	}
}
