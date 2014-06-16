using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayPalPreapprovedUpdateReply
	{
		private string reasonCodeField;
		private string requestDateTimeField;
		private string reconciliationIDField;
		private string payerStatusField;
		private string payerNameField;
		private string payerCountryField;
		private string mpStatusField;
		private string payerField;
		private string payerIDField;
		private string payerBusinessField;
		private string descField;
		private string mpMaxField;
		private string paymentSourceIDField;
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
		public string payerStatus
		{
			get
			{
				return this.payerStatusField;
			}
			set
			{
				this.payerStatusField = value;
			}
		}
		public string payerName
		{
			get
			{
				return this.payerNameField;
			}
			set
			{
				this.payerNameField = value;
			}
		}
		public string payerCountry
		{
			get
			{
				return this.payerCountryField;
			}
			set
			{
				this.payerCountryField = value;
			}
		}
		public string mpStatus
		{
			get
			{
				return this.mpStatusField;
			}
			set
			{
				this.mpStatusField = value;
			}
		}
		public string payer
		{
			get
			{
				return this.payerField;
			}
			set
			{
				this.payerField = value;
			}
		}
		public string payerID
		{
			get
			{
				return this.payerIDField;
			}
			set
			{
				this.payerIDField = value;
			}
		}
		public string payerBusiness
		{
			get
			{
				return this.payerBusinessField;
			}
			set
			{
				this.payerBusinessField = value;
			}
		}
		public string desc
		{
			get
			{
				return this.descField;
			}
			set
			{
				this.descField = value;
			}
		}
		public string mpMax
		{
			get
			{
				return this.mpMaxField;
			}
			set
			{
				this.mpMaxField = value;
			}
		}
		public string paymentSourceID
		{
			get
			{
				return this.paymentSourceIDField;
			}
			set
			{
				this.paymentSourceIDField = value;
			}
		}
	}
}
