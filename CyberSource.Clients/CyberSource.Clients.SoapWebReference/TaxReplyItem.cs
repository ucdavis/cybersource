using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class TaxReplyItem
	{
		private string cityTaxAmountField;
		private string countyTaxAmountField;
		private string districtTaxAmountField;
		private string stateTaxAmountField;
		private string totalTaxAmountField;
		private string idField;
		public string cityTaxAmount
		{
			get
			{
				return this.cityTaxAmountField;
			}
			set
			{
				this.cityTaxAmountField = value;
			}
		}
		public string countyTaxAmount
		{
			get
			{
				return this.countyTaxAmountField;
			}
			set
			{
				this.countyTaxAmountField = value;
			}
		}
		public string districtTaxAmount
		{
			get
			{
				return this.districtTaxAmountField;
			}
			set
			{
				this.districtTaxAmountField = value;
			}
		}
		public string stateTaxAmount
		{
			get
			{
				return this.stateTaxAmountField;
			}
			set
			{
				this.stateTaxAmountField = value;
			}
		}
		public string totalTaxAmount
		{
			get
			{
				return this.totalTaxAmountField;
			}
			set
			{
				this.totalTaxAmountField = value;
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
