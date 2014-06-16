using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class TaxService
	{
		private string nexusField;
		private string noNexusField;
		private string orderAcceptanceCityField;
		private string orderAcceptanceCountyField;
		private string orderAcceptanceCountryField;
		private string orderAcceptanceStateField;
		private string orderAcceptancePostalCodeField;
		private string orderOriginCityField;
		private string orderOriginCountyField;
		private string orderOriginCountryField;
		private string orderOriginStateField;
		private string orderOriginPostalCodeField;
		private string sellerRegistrationField;
		private string buyerRegistrationField;
		private string middlemanRegistrationField;
		private string pointOfTitleTransferField;
		private string runField;
		public string nexus
		{
			get
			{
				return this.nexusField;
			}
			set
			{
				this.nexusField = value;
			}
		}
		public string noNexus
		{
			get
			{
				return this.noNexusField;
			}
			set
			{
				this.noNexusField = value;
			}
		}
		public string orderAcceptanceCity
		{
			get
			{
				return this.orderAcceptanceCityField;
			}
			set
			{
				this.orderAcceptanceCityField = value;
			}
		}
		public string orderAcceptanceCounty
		{
			get
			{
				return this.orderAcceptanceCountyField;
			}
			set
			{
				this.orderAcceptanceCountyField = value;
			}
		}
		public string orderAcceptanceCountry
		{
			get
			{
				return this.orderAcceptanceCountryField;
			}
			set
			{
				this.orderAcceptanceCountryField = value;
			}
		}
		public string orderAcceptanceState
		{
			get
			{
				return this.orderAcceptanceStateField;
			}
			set
			{
				this.orderAcceptanceStateField = value;
			}
		}
		public string orderAcceptancePostalCode
		{
			get
			{
				return this.orderAcceptancePostalCodeField;
			}
			set
			{
				this.orderAcceptancePostalCodeField = value;
			}
		}
		public string orderOriginCity
		{
			get
			{
				return this.orderOriginCityField;
			}
			set
			{
				this.orderOriginCityField = value;
			}
		}
		public string orderOriginCounty
		{
			get
			{
				return this.orderOriginCountyField;
			}
			set
			{
				this.orderOriginCountyField = value;
			}
		}
		public string orderOriginCountry
		{
			get
			{
				return this.orderOriginCountryField;
			}
			set
			{
				this.orderOriginCountryField = value;
			}
		}
		public string orderOriginState
		{
			get
			{
				return this.orderOriginStateField;
			}
			set
			{
				this.orderOriginStateField = value;
			}
		}
		public string orderOriginPostalCode
		{
			get
			{
				return this.orderOriginPostalCodeField;
			}
			set
			{
				this.orderOriginPostalCodeField = value;
			}
		}
		public string sellerRegistration
		{
			get
			{
				return this.sellerRegistrationField;
			}
			set
			{
				this.sellerRegistrationField = value;
			}
		}
		public string buyerRegistration
		{
			get
			{
				return this.buyerRegistrationField;
			}
			set
			{
				this.buyerRegistrationField = value;
			}
		}
		public string middlemanRegistration
		{
			get
			{
				return this.middlemanRegistrationField;
			}
			set
			{
				this.middlemanRegistrationField = value;
			}
		}
		public string pointOfTitleTransfer
		{
			get
			{
				return this.pointOfTitleTransferField;
			}
			set
			{
				this.pointOfTitleTransferField = value;
			}
		}
		[XmlAttribute]
		public string run
		{
			get
			{
				return this.runField;
			}
			set
			{
				this.runField = value;
			}
		}
	}
}
