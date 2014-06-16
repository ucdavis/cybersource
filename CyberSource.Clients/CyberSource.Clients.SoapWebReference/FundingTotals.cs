using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class FundingTotals
	{
		private string currencyField;
		private string grandTotalAmountField;
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
	}
}
