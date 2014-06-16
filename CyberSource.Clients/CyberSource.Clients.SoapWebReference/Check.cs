using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Check
	{
		private string fullNameField;
		private string accountNumberField;
		private string accountTypeField;
		private string bankTransitNumberField;
		private string checkNumberField;
		private string accountEncoderIDField;
		public string fullName
		{
			get
			{
				return this.fullNameField;
			}
			set
			{
				this.fullNameField = value;
			}
		}
		public string accountNumber
		{
			get
			{
				return this.accountNumberField;
			}
			set
			{
				this.accountNumberField = value;
			}
		}
		public string accountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.accountTypeField = value;
			}
		}
		public string bankTransitNumber
		{
			get
			{
				return this.bankTransitNumberField;
			}
			set
			{
				this.bankTransitNumberField = value;
			}
		}
		public string checkNumber
		{
			get
			{
				return this.checkNumberField;
			}
			set
			{
				this.checkNumberField = value;
			}
		}
		public string accountEncoderID
		{
			get
			{
				return this.accountEncoderIDField;
			}
			set
			{
				this.accountEncoderIDField = value;
			}
		}
	}
}
