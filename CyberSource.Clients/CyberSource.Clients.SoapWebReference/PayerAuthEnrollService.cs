using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class PayerAuthEnrollService
	{
		private string httpAcceptField;
		private string httpUserAgentField;
		private string merchantNameField;
		private string merchantURLField;
		private string purchaseDescriptionField;
		private string purchaseTimeField;
		private string countryCodeField;
		private string acquirerBinField;
		private string loginIDField;
		private string passwordField;
		private string merchantIDField;
		private string runField;
		public string httpAccept
		{
			get
			{
				return this.httpAcceptField;
			}
			set
			{
				this.httpAcceptField = value;
			}
		}
		public string httpUserAgent
		{
			get
			{
				return this.httpUserAgentField;
			}
			set
			{
				this.httpUserAgentField = value;
			}
		}
		public string merchantName
		{
			get
			{
				return this.merchantNameField;
			}
			set
			{
				this.merchantNameField = value;
			}
		}
		public string merchantURL
		{
			get
			{
				return this.merchantURLField;
			}
			set
			{
				this.merchantURLField = value;
			}
		}
		public string purchaseDescription
		{
			get
			{
				return this.purchaseDescriptionField;
			}
			set
			{
				this.purchaseDescriptionField = value;
			}
		}
		public string purchaseTime
		{
			get
			{
				return this.purchaseTimeField;
			}
			set
			{
				this.purchaseTimeField = value;
			}
		}
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		public string acquirerBin
		{
			get
			{
				return this.acquirerBinField;
			}
			set
			{
				this.acquirerBinField = value;
			}
		}
		public string loginID
		{
			get
			{
				return this.loginIDField;
			}
			set
			{
				this.loginIDField = value;
			}
		}
		public string password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}
		public string merchantID
		{
			get
			{
				return this.merchantIDField;
			}
			set
			{
				this.merchantIDField = value;
			}
		}
		[XmlAttribute]
		public string run
		{
			get
			{
				return this.runField;
			}
			set
			{
				this.runField = value;
			}
		}
	}
}
