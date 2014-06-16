using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Leg
	{
		private string carrierCodeField;
		private string flightNumberField;
		private string originatingAirportCodeField;
		private string classField;
		private string stopoverCodeField;
		private string departureDateField;
		private string destinationField;
		private string fareBasisField;
		private string departTaxField;
		private string conjunctionTicketField;
		private string exchangeTicketField;
		private string couponNumberField;
		private string departureTimeField;
		private string departureTimeSegmentField;
		private string arrivalTimeField;
		private string arrivalTimeSegmentField;
		private string endorsementsRestrictionsField;
		private string idField;
		public string carrierCode
		{
			get
			{
				return this.carrierCodeField;
			}
			set
			{
				this.carrierCodeField = value;
			}
		}
		public string flightNumber
		{
			get
			{
				return this.flightNumberField;
			}
			set
			{
				this.flightNumberField = value;
			}
		}
		public string originatingAirportCode
		{
			get
			{
				return this.originatingAirportCodeField;
			}
			set
			{
				this.originatingAirportCodeField = value;
			}
		}
		public string @class
		{
			get
			{
				return this.classField;
			}
			set
			{
				this.classField = value;
			}
		}
		public string stopoverCode
		{
			get
			{
				return this.stopoverCodeField;
			}
			set
			{
				this.stopoverCodeField = value;
			}
		}
		public string departureDate
		{
			get
			{
				return this.departureDateField;
			}
			set
			{
				this.departureDateField = value;
			}
		}
		public string destination
		{
			get
			{
				return this.destinationField;
			}
			set
			{
				this.destinationField = value;
			}
		}
		public string fareBasis
		{
			get
			{
				return this.fareBasisField;
			}
			set
			{
				this.fareBasisField = value;
			}
		}
		public string departTax
		{
			get
			{
				return this.departTaxField;
			}
			set
			{
				this.departTaxField = value;
			}
		}
		public string conjunctionTicket
		{
			get
			{
				return this.conjunctionTicketField;
			}
			set
			{
				this.conjunctionTicketField = value;
			}
		}
		public string exchangeTicket
		{
			get
			{
				return this.exchangeTicketField;
			}
			set
			{
				this.exchangeTicketField = value;
			}
		}
		public string couponNumber
		{
			get
			{
				return this.couponNumberField;
			}
			set
			{
				this.couponNumberField = value;
			}
		}
		public string departureTime
		{
			get
			{
				return this.departureTimeField;
			}
			set
			{
				this.departureTimeField = value;
			}
		}
		public string departureTimeSegment
		{
			get
			{
				return this.departureTimeSegmentField;
			}
			set
			{
				this.departureTimeSegmentField = value;
			}
		}
		public string arrivalTime
		{
			get
			{
				return this.arrivalTimeField;
			}
			set
			{
				this.arrivalTimeField = value;
			}
		}
		public string arrivalTimeSegment
		{
			get
			{
				return this.arrivalTimeSegmentField;
			}
			set
			{
				this.arrivalTimeSegmentField = value;
			}
		}
		public string endorsementsRestrictions
		{
			get
			{
				return this.endorsementsRestrictionsField;
			}
			set
			{
				this.endorsementsRestrictionsField = value;
			}
		}
		[XmlAttribute(DataType = "integer")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
	}
}
