using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class AirlineData
	{
		private string agentCodeField;
		private string agentNameField;
		private string ticketIssuerCityField;
		private string ticketIssuerStateField;
		private string ticketIssuerPostalCodeField;
		private string ticketIssuerCountryField;
		private string ticketIssuerCodeField;
		private string ticketIssuerNameField;
		private string ticketNumberField;
		private string checkDigitField;
		private string restrictedTicketIndicatorField;
		private string transactionTypeField;
		private string extendedPaymentCodeField;
		private string carrierNameField;
		private string passengerNameField;
		private string customerCodeField;
		private string documentTypeField;
		private string documentNumberField;
		private string documentNumberOfPartsField;
		private string invoiceNumberField;
		private string invoiceDateField;
		private string chargeDetailsField;
		private string bookingReferenceField;
		private string totalFeeField;
		private string clearingSequenceField;
		private string clearingCountField;
		private string totalClearingAmountField;
		private Leg[] legField;
		private string numberOfPassengersField;
		public string agentCode
		{
			get
			{
				return this.agentCodeField;
			}
			set
			{
				this.agentCodeField = value;
			}
		}
		public string agentName
		{
			get
			{
				return this.agentNameField;
			}
			set
			{
				this.agentNameField = value;
			}
		}
		public string ticketIssuerCity
		{
			get
			{
				return this.ticketIssuerCityField;
			}
			set
			{
				this.ticketIssuerCityField = value;
			}
		}
		public string ticketIssuerState
		{
			get
			{
				return this.ticketIssuerStateField;
			}
			set
			{
				this.ticketIssuerStateField = value;
			}
		}
		public string ticketIssuerPostalCode
		{
			get
			{
				return this.ticketIssuerPostalCodeField;
			}
			set
			{
				this.ticketIssuerPostalCodeField = value;
			}
		}
		public string ticketIssuerCountry
		{
			get
			{
				return this.ticketIssuerCountryField;
			}
			set
			{
				this.ticketIssuerCountryField = value;
			}
		}
		public string ticketIssuerCode
		{
			get
			{
				return this.ticketIssuerCodeField;
			}
			set
			{
				this.ticketIssuerCodeField = value;
			}
		}
		public string ticketIssuerName
		{
			get
			{
				return this.ticketIssuerNameField;
			}
			set
			{
				this.ticketIssuerNameField = value;
			}
		}
		public string ticketNumber
		{
			get
			{
				return this.ticketNumberField;
			}
			set
			{
				this.ticketNumberField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string checkDigit
		{
			get
			{
				return this.checkDigitField;
			}
			set
			{
				this.checkDigitField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string restrictedTicketIndicator
		{
			get
			{
				return this.restrictedTicketIndicatorField;
			}
			set
			{
				this.restrictedTicketIndicatorField = value;
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
		public string extendedPaymentCode
		{
			get
			{
				return this.extendedPaymentCodeField;
			}
			set
			{
				this.extendedPaymentCodeField = value;
			}
		}
		public string carrierName
		{
			get
			{
				return this.carrierNameField;
			}
			set
			{
				this.carrierNameField = value;
			}
		}
		public string passengerName
		{
			get
			{
				return this.passengerNameField;
			}
			set
			{
				this.passengerNameField = value;
			}
		}
		public string customerCode
		{
			get
			{
				return this.customerCodeField;
			}
			set
			{
				this.customerCodeField = value;
			}
		}
		public string documentType
		{
			get
			{
				return this.documentTypeField;
			}
			set
			{
				this.documentTypeField = value;
			}
		}
		public string documentNumber
		{
			get
			{
				return this.documentNumberField;
			}
			set
			{
				this.documentNumberField = value;
			}
		}
		public string documentNumberOfParts
		{
			get
			{
				return this.documentNumberOfPartsField;
			}
			set
			{
				this.documentNumberOfPartsField = value;
			}
		}
		public string invoiceNumber
		{
			get
			{
				return this.invoiceNumberField;
			}
			set
			{
				this.invoiceNumberField = value;
			}
		}
		public string invoiceDate
		{
			get
			{
				return this.invoiceDateField;
			}
			set
			{
				this.invoiceDateField = value;
			}
		}
		public string chargeDetails
		{
			get
			{
				return this.chargeDetailsField;
			}
			set
			{
				this.chargeDetailsField = value;
			}
		}
		public string bookingReference
		{
			get
			{
				return this.bookingReferenceField;
			}
			set
			{
				this.bookingReferenceField = value;
			}
		}
		public string totalFee
		{
			get
			{
				return this.totalFeeField;
			}
			set
			{
				this.totalFeeField = value;
			}
		}
		public string clearingSequence
		{
			get
			{
				return this.clearingSequenceField;
			}
			set
			{
				this.clearingSequenceField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string clearingCount
		{
			get
			{
				return this.clearingCountField;
			}
			set
			{
				this.clearingCountField = value;
			}
		}
		public string totalClearingAmount
		{
			get
			{
				return this.totalClearingAmountField;
			}
			set
			{
				this.totalClearingAmountField = value;
			}
		}
		[XmlElement("leg")]
		public Leg[] leg
		{
			get
			{
				return this.legField;
			}
			set
			{
				this.legField = value;
			}
		}
		public string numberOfPassengers
		{
			get
			{
				return this.numberOfPassengersField;
			}
			set
			{
				this.numberOfPassengersField = value;
			}
		}
	}
}
