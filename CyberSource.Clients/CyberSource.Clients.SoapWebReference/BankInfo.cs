using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class BankInfo
	{
		private string bankCodeField;
		private string nameField;
		private string addressField;
		private string cityField;
		private string countryField;
		private string branchCodeField;
		private string swiftCodeField;
		private string sortCodeField;
		private string issuerIDField;
		public string bankCode
		{
			get
			{
				return this.bankCodeField;
			}
			set
			{
				this.bankCodeField = value;
			}
		}
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public string address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		public string country
		{
			get
			{
				return this.countryField;
			}
			set
			{
				this.countryField = value;
			}
		}
		public string branchCode
		{
			get
			{
				return this.branchCodeField;
			}
			set
			{
				this.branchCodeField = value;
			}
		}
		public string swiftCode
		{
			get
			{
				return this.swiftCodeField;
			}
			set
			{
				this.swiftCodeField = value;
			}
		}
		public string sortCode
		{
			get
			{
				return this.sortCodeField;
			}
			set
			{
				this.sortCodeField = value;
			}
		}
		public string issuerID
		{
			get
			{
				return this.issuerIDField;
			}
			set
			{
				this.issuerIDField = value;
			}
		}
	}
}
