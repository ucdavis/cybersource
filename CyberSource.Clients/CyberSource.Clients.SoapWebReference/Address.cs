using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Address
	{
		private string street1Field;
		private string street2Field;
		private string cityField;
		private string stateField;
		private string postalCodeField;
		private string countryField;
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
	}
}
