using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class CCAuthService
	{
		private string cavvField;
		private string commerceIndicatorField;
		private string eciRawField;
		private string xidField;
		private string reconciliationIDField;
		private string avsLevelField;
		private string fxQuoteIDField;
		private string returnAuthRecordField;
		private string authTypeField;
		private string verbalAuthCodeField;
		private string billPaymentField;
		private string authenticationXIDField;
		private string authorizationXIDField;
		private string industryDatatypeField;
		private string traceNumberField;
		private string runField;
		public string cavv
		{
			get
			{
				return this.cavvField;
			}
			set
			{
				this.cavvField = value;
			}
		}
		public string commerceIndicator
		{
			get
			{
				return this.commerceIndicatorField;
			}
			set
			{
				this.commerceIndicatorField = value;
			}
		}
		public string eciRaw
		{
			get
			{
				return this.eciRawField;
			}
			set
			{
				this.eciRawField = value;
			}
		}
		public string xid
		{
			get
			{
				return this.xidField;
			}
			set
			{
				this.xidField = value;
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
		public string avsLevel
		{
			get
			{
				return this.avsLevelField;
			}
			set
			{
				this.avsLevelField = value;
			}
		}
		public string fxQuoteID
		{
			get
			{
				return this.fxQuoteIDField;
			}
			set
			{
				this.fxQuoteIDField = value;
			}
		}
		public string returnAuthRecord
		{
			get
			{
				return this.returnAuthRecordField;
			}
			set
			{
				this.returnAuthRecordField = value;
			}
		}
		public string authType
		{
			get
			{
				return this.authTypeField;
			}
			set
			{
				this.authTypeField = value;
			}
		}
		public string verbalAuthCode
		{
			get
			{
				return this.verbalAuthCodeField;
			}
			set
			{
				this.verbalAuthCodeField = value;
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
		public string authenticationXID
		{
			get
			{
				return this.authenticationXIDField;
			}
			set
			{
				this.authenticationXIDField = value;
			}
		}
		public string authorizationXID
		{
			get
			{
				return this.authorizationXIDField;
			}
			set
			{
				this.authorizationXIDField = value;
			}
		}
		public string industryDatatype
		{
			get
			{
				return this.industryDatatypeField;
			}
			set
			{
				this.industryDatatypeField = value;
			}
		}
		public string traceNumber
		{
			get
			{
				return this.traceNumberField;
			}
			set
			{
				this.traceNumberField = value;
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
