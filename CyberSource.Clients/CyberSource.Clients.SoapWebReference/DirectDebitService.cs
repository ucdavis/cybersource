using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class DirectDebitService
	{
		private string dateCollectField;
		private string directDebitTextField;
		private string authorizationIDField;
		private string transactionTypeField;
		private string directDebitTypeField;
		private string validateRequestIDField;
		private string recurringTypeField;
		private string mandateIDField;
		private string validateRequestTokenField;
		private string runField;
		public string dateCollect
		{
			get
			{
				return this.dateCollectField;
			}
			set
			{
				this.dateCollectField = value;
			}
		}
		public string directDebitText
		{
			get
			{
				return this.directDebitTextField;
			}
			set
			{
				this.directDebitTextField = value;
			}
		}
		public string authorizationID
		{
			get
			{
				return this.authorizationIDField;
			}
			set
			{
				this.authorizationIDField = value;
			}
		}
		public string transactionType
		{
			get
			{
				return this.transactionTypeField;
			}
			set
			{
				this.transactionTypeField = value;
			}
		}
		public string directDebitType
		{
			get
			{
				return this.directDebitTypeField;
			}
			set
			{
				this.directDebitTypeField = value;
			}
		}
		public string validateRequestID
		{
			get
			{
				return this.validateRequestIDField;
			}
			set
			{
				this.validateRequestIDField = value;
			}
		}
		public string recurringType
		{
			get
			{
				return this.recurringTypeField;
			}
			set
			{
				this.recurringTypeField = value;
			}
		}
		public string mandateID
		{
			get
			{
				return this.mandateIDField;
			}
			set
			{
				this.mandateIDField = value;
			}
		}
		public string validateRequestToken
		{
			get
			{
				return this.validateRequestTokenField;
			}
			set
			{
				this.validateRequestTokenField = value;
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
