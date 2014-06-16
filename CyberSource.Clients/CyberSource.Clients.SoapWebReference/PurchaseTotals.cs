using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PurchaseTotals
	{
		private string currencyField;
		private string discountAmountField;
		private string taxAmountField;
		private string dutyAmountField;
		private string grandTotalAmountField;
		private string freightAmountField;
		public string currency
		{
			get
			{
				return this.currencyField;
			}
			set
			{
				this.currencyField = value;
			}
		}
		public string discountAmount
		{
			get
			{
				return this.discountAmountField;
			}
			set
			{
				this.discountAmountField = value;
			}
		}
		public string taxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		public string dutyAmount
		{
			get
			{
				return this.dutyAmountField;
			}
			set
			{
				this.dutyAmountField = value;
			}
		}
		public string grandTotalAmount
		{
			get
			{
				return this.grandTotalAmountField;
			}
			set
			{
				this.grandTotalAmountField = value;
			}
		}
		public string freightAmount
		{
			get
			{
				return this.freightAmountField;
			}
			set
			{
				this.freightAmountField = value;
			}
		}
	}
}
