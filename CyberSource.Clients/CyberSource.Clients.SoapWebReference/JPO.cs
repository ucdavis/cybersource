using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class JPO
	{
		private string paymentMethodField;
		private string bonusAmountField;
		private string bonusesField;
		private string installmentsField;
		[XmlElement(DataType = "integer")]
		public string paymentMethod
		{
			get
			{
				return this.paymentMethodField;
			}
			set
			{
				this.paymentMethodField = value;
			}
		}
		public string bonusAmount
		{
			get
			{
				return this.bonusAmountField;
			}
			set
			{
				this.bonusAmountField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string bonuses
		{
			get
			{
				return this.bonusesField;
			}
			set
			{
				this.bonusesField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string installments
		{
			get
			{
				return this.installmentsField;
			}
			set
			{
				this.installmentsField = value;
			}
		}
	}
}
