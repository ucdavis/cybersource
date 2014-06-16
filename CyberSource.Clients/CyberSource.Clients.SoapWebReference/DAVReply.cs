using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DAVReply
	{
		private string reasonCodeField;
		private string addressTypeField;
		private string apartmentInfoField;
		private string barCodeField;
		private string barCodeCheckDigitField;
		private string careOfField;
		private string cityInfoField;
		private string countryInfoField;
		private string directionalInfoField;
		private string lvrInfoField;
		private string matchScoreField;
		private string standardizedAddress1Field;
		private string standardizedAddress2Field;
		private string standardizedAddress3Field;
		private string standardizedAddress4Field;
		private string standardizedAddressNoAptField;
		private string standardizedCityField;
		private string standardizedCountyField;
		private string standardizedCSPField;
		private string standardizedStateField;
		private string standardizedPostalCodeField;
		private string standardizedCountryField;
		private string standardizedISOCountryField;
		private string stateInfoField;
		private string streetInfoField;
		private string suffixInfoField;
		private string postalCodeInfoField;
		private string overallInfoField;
		private string usInfoField;
		private string caInfoField;
		private string intlInfoField;
		private string usErrorInfoField;
		private string caErrorInfoField;
		private string intlErrorInfoField;
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
		public string addressType
		{
			get
			{
				return this.addressTypeField;
			}
			set
			{
				this.addressTypeField = value;
			}
		}
		public string apartmentInfo
		{
			get
			{
				return this.apartmentInfoField;
			}
			set
			{
				this.apartmentInfoField = value;
			}
		}
		public string barCode
		{
			get
			{
				return this.barCodeField;
			}
			set
			{
				this.barCodeField = value;
			}
		}
		public string barCodeCheckDigit
		{
			get
			{
				return this.barCodeCheckDigitField;
			}
			set
			{
				this.barCodeCheckDigitField = value;
			}
		}
		public string careOf
		{
			get
			{
				return this.careOfField;
			}
			set
			{
				this.careOfField = value;
			}
		}
		public string cityInfo
		{
			get
			{
				return this.cityInfoField;
			}
			set
			{
				this.cityInfoField = value;
			}
		}
		public string countryInfo
		{
			get
			{
				return this.countryInfoField;
			}
			set
			{
				this.countryInfoField = value;
			}
		}
		public string directionalInfo
		{
			get
			{
				return this.directionalInfoField;
			}
			set
			{
				this.directionalInfoField = value;
			}
		}
		public string lvrInfo
		{
			get
			{
				return this.lvrInfoField;
			}
			set
			{
				this.lvrInfoField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string matchScore
		{
			get
			{
				return this.matchScoreField;
			}
			set
			{
				this.matchScoreField = value;
			}
		}
		public string standardizedAddress1
		{
			get
			{
				return this.standardizedAddress1Field;
			}
			set
			{
				this.standardizedAddress1Field = value;
			}
		}
		public string standardizedAddress2
		{
			get
			{
				return this.standardizedAddress2Field;
			}
			set
			{
				this.standardizedAddress2Field = value;
			}
		}
		public string standardizedAddress3
		{
			get
			{
				return this.standardizedAddress3Field;
			}
			set
			{
				this.standardizedAddress3Field = value;
			}
		}
		public string standardizedAddress4
		{
			get
			{
				return this.standardizedAddress4Field;
			}
			set
			{
				this.standardizedAddress4Field = value;
			}
		}
		public string standardizedAddressNoApt
		{
			get
			{
				return this.standardizedAddressNoAptField;
			}
			set
			{
				this.standardizedAddressNoAptField = value;
			}
		}
		public string standardizedCity
		{
			get
			{
				return this.standardizedCityField;
			}
			set
			{
				this.standardizedCityField = value;
			}
		}
		public string standardizedCounty
		{
			get
			{
				return this.standardizedCountyField;
			}
			set
			{
				this.standardizedCountyField = value;
			}
		}
		public string standardizedCSP
		{
			get
			{
				return this.standardizedCSPField;
			}
			set
			{
				this.standardizedCSPField = value;
			}
		}
		public string standardizedState
		{
			get
			{
				return this.standardizedStateField;
			}
			set
			{
				this.standardizedStateField = value;
			}
		}
		public string standardizedPostalCode
		{
			get
			{
				return this.standardizedPostalCodeField;
			}
			set
			{
				this.standardizedPostalCodeField = value;
			}
		}
		public string standardizedCountry
		{
			get
			{
				return this.standardizedCountryField;
			}
			set
			{
				this.standardizedCountryField = value;
			}
		}
		public string standardizedISOCountry
		{
			get
			{
				return this.standardizedISOCountryField;
			}
			set
			{
				this.standardizedISOCountryField = value;
			}
		}
		public string stateInfo
		{
			get
			{
				return this.stateInfoField;
			}
			set
			{
				this.stateInfoField = value;
			}
		}
		public string streetInfo
		{
			get
			{
				return this.streetInfoField;
			}
			set
			{
				this.streetInfoField = value;
			}
		}
		public string suffixInfo
		{
			get
			{
				return this.suffixInfoField;
			}
			set
			{
				this.suffixInfoField = value;
			}
		}
		public string postalCodeInfo
		{
			get
			{
				return this.postalCodeInfoField;
			}
			set
			{
				this.postalCodeInfoField = value;
			}
		}
		public string overallInfo
		{
			get
			{
				return this.overallInfoField;
			}
			set
			{
				this.overallInfoField = value;
			}
		}
		public string usInfo
		{
			get
			{
				return this.usInfoField;
			}
			set
			{
				this.usInfoField = value;
			}
		}
		public string caInfo
		{
			get
			{
				return this.caInfoField;
			}
			set
			{
				this.caInfoField = value;
			}
		}
		public string intlInfo
		{
			get
			{
				return this.intlInfoField;
			}
			set
			{
				this.intlInfoField = value;
			}
		}
		public string usErrorInfo
		{
			get
			{
				return this.usErrorInfoField;
			}
			set
			{
				this.usErrorInfoField = value;
			}
		}
		public string caErrorInfo
		{
			get
			{
				return this.caErrorInfoField;
			}
			set
			{
				this.caErrorInfoField = value;
			}
		}
		public string intlErrorInfo
		{
			get
			{
				return this.intlErrorInfoField;
			}
			set
			{
				this.intlErrorInfoField = value;
			}
		}
	}
}
