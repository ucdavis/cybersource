using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class RecurringSubscriptionInfo
	{
		private string subscriptionIDField;
		private string statusField;
		private string amountField;
		private string numberOfPaymentsField;
		private string numberOfPaymentsToAddField;
		private string automaticRenewField;
		private string frequencyField;
		private string startDateField;
		private string endDateField;
		private string approvalRequiredField;
		private PaySubscriptionEvent eventField;
		private string billPaymentField;
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
		public string amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string numberOfPayments
		{
			get
			{
				return this.numberOfPaymentsField;
			}
			set
			{
				this.numberOfPaymentsField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string numberOfPaymentsToAdd
		{
			get
			{
				return this.numberOfPaymentsToAddField;
			}
			set
			{
				this.numberOfPaymentsToAddField = value;
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
		public PaySubscriptionEvent @event
		{
			get
			{
				return this.eventField;
			}
			set
			{
				this.eventField = value;
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
	}
}
