using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class ReplyMessage
	{
		private string merchantReferenceCodeField;
		private string requestIDField;
		private string decisionField;
		private string reasonCodeField;
		private string[] missingFieldField;
		private string[] invalidFieldField;
		private string requestTokenField;
		private PurchaseTotals purchaseTotalsField;
		private DeniedPartiesMatch[] deniedPartiesMatchField;
		private CCAuthReply ccAuthReplyField;
		private CCCaptureReply ccCaptureReplyField;
		private CCCreditReply ccCreditReplyField;
		private CCAuthReversalReply ccAuthReversalReplyField;
		private ECDebitReply ecDebitReplyField;
		private ECCreditReply ecCreditReplyField;
		private PayerAuthEnrollReply payerAuthEnrollReplyField;
		private PayerAuthValidateReply payerAuthValidateReplyField;
		private TaxReply taxReplyField;
		private AFSReply afsReplyField;
		private DAVReply davReplyField;
		private ExportReply exportReplyField;
		private FXRatesReply fxRatesReplyField;
		private BankTransferReply bankTransferReplyField;
		private BankTransferRefundReply bankTransferRefundReplyField;
		private BankTransferRealTimeReply bankTransferRealTimeReplyField;
		private DirectDebitMandateReply directDebitMandateReplyField;
		private DirectDebitReply directDebitReplyField;
		private DirectDebitValidateReply directDebitValidateReplyField;
		private DirectDebitRefundReply directDebitRefundReplyField;
		private PaySubscriptionCreateReply paySubscriptionCreateReplyField;
		private PaySubscriptionUpdateReply paySubscriptionUpdateReplyField;
		private PaySubscriptionEventUpdateReply paySubscriptionEventUpdateReplyField;
		private PaySubscriptionRetrieveReply paySubscriptionRetrieveReplyField;
		private PayPalPaymentReply payPalPaymentReplyField;
		private PayPalCreditReply payPalCreditReplyField;
		private VoidReply voidReplyField;
		private PinlessDebitReply pinlessDebitReplyField;
		private PinlessDebitValidateReply pinlessDebitValidateReplyField;
		private PayPalButtonCreateReply payPalButtonCreateReplyField;
		private PayPalPreapprovedPaymentReply payPalPreapprovedPaymentReplyField;
		private PayPalPreapprovedUpdateReply payPalPreapprovedUpdateReplyField;
		private RiskUpdateReply riskUpdateReplyField;
		private DecisionReply decisionReplyField;
		private XmlElement reservedField;
		public string merchantReferenceCode
		{
			get
			{
				return this.merchantReferenceCodeField;
			}
			set
			{
				this.merchantReferenceCodeField = value;
			}
		}
		public string requestID
		{
			get
			{
				return this.requestIDField;
			}
			set
			{
				this.requestIDField = value;
			}
		}
		public string decision
		{
			get
			{
				return this.decisionField;
			}
			set
			{
				this.decisionField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string reasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
		[XmlElement("missingField")]
		public string[] missingField
		{
			get
			{
				return this.missingFieldField;
			}
			set
			{
				this.missingFieldField = value;
			}
		}
		[XmlElement("invalidField")]
		public string[] invalidField
		{
			get
			{
				return this.invalidFieldField;
			}
			set
			{
				this.invalidFieldField = value;
			}
		}
		public string requestToken
		{
			get
			{
				return this.requestTokenField;
			}
			set
			{
				this.requestTokenField = value;
			}
		}
		public PurchaseTotals purchaseTotals
		{
			get
			{
				return this.purchaseTotalsField;
			}
			set
			{
				this.purchaseTotalsField = value;
			}
		}
		[XmlElement("deniedPartiesMatch")]
		public DeniedPartiesMatch[] deniedPartiesMatch
		{
			get
			{
				return this.deniedPartiesMatchField;
			}
			set
			{
				this.deniedPartiesMatchField = value;
			}
		}
		public CCAuthReply ccAuthReply
		{
			get
			{
				return this.ccAuthReplyField;
			}
			set
			{
				this.ccAuthReplyField = value;
			}
		}
		public CCCaptureReply ccCaptureReply
		{
			get
			{
				return this.ccCaptureReplyField;
			}
			set
			{
				this.ccCaptureReplyField = value;
			}
		}
		public CCCreditReply ccCreditReply
		{
			get
			{
				return this.ccCreditReplyField;
			}
			set
			{
				this.ccCreditReplyField = value;
			}
		}
		public CCAuthReversalReply ccAuthReversalReply
		{
			get
			{
				return this.ccAuthReversalReplyField;
			}
			set
			{
				this.ccAuthReversalReplyField = value;
			}
		}
		public ECDebitReply ecDebitReply
		{
			get
			{
				return this.ecDebitReplyField;
			}
			set
			{
				this.ecDebitReplyField = value;
			}
		}
		public ECCreditReply ecCreditReply
		{
			get
			{
				return this.ecCreditReplyField;
			}
			set
			{
				this.ecCreditReplyField = value;
			}
		}
		public PayerAuthEnrollReply payerAuthEnrollReply
		{
			get
			{
				return this.payerAuthEnrollReplyField;
			}
			set
			{
				this.payerAuthEnrollReplyField = value;
			}
		}
		public PayerAuthValidateReply payerAuthValidateReply
		{
			get
			{
				return this.payerAuthValidateReplyField;
			}
			set
			{
				this.payerAuthValidateReplyField = value;
			}
		}
		public TaxReply taxReply
		{
			get
			{
				return this.taxReplyField;
			}
			set
			{
				this.taxReplyField = value;
			}
		}
		public AFSReply afsReply
		{
			get
			{
				return this.afsReplyField;
			}
			set
			{
				this.afsReplyField = value;
			}
		}
		public DAVReply davReply
		{
			get
			{
				return this.davReplyField;
			}
			set
			{
				this.davReplyField = value;
			}
		}
		public ExportReply exportReply
		{
			get
			{
				return this.exportReplyField;
			}
			set
			{
				this.exportReplyField = value;
			}
		}
		public FXRatesReply fxRatesReply
		{
			get
			{
				return this.fxRatesReplyField;
			}
			set
			{
				this.fxRatesReplyField = value;
			}
		}
		public BankTransferReply bankTransferReply
		{
			get
			{
				return this.bankTransferReplyField;
			}
			set
			{
				this.bankTransferReplyField = value;
			}
		}
		public BankTransferRefundReply bankTransferRefundReply
		{
			get
			{
				return this.bankTransferRefundReplyField;
			}
			set
			{
				this.bankTransferRefundReplyField = value;
			}
		}
		public BankTransferRealTimeReply bankTransferRealTimeReply
		{
			get
			{
				return this.bankTransferRealTimeReplyField;
			}
			set
			{
				this.bankTransferRealTimeReplyField = value;
			}
		}
		public DirectDebitMandateReply directDebitMandateReply
		{
			get
			{
				return this.directDebitMandateReplyField;
			}
			set
			{
				this.directDebitMandateReplyField = value;
			}
		}
		public DirectDebitReply directDebitReply
		{
			get
			{
				return this.directDebitReplyField;
			}
			set
			{
				this.directDebitReplyField = value;
			}
		}
		public DirectDebitValidateReply directDebitValidateReply
		{
			get
			{
				return this.directDebitValidateReplyField;
			}
			set
			{
				this.directDebitValidateReplyField = value;
			}
		}
		public DirectDebitRefundReply directDebitRefundReply
		{
			get
			{
				return this.directDebitRefundReplyField;
			}
			set
			{
				this.directDebitRefundReplyField = value;
			}
		}
		public PaySubscriptionCreateReply paySubscriptionCreateReply
		{
			get
			{
				return this.paySubscriptionCreateReplyField;
			}
			set
			{
				this.paySubscriptionCreateReplyField = value;
			}
		}
		public PaySubscriptionUpdateReply paySubscriptionUpdateReply
		{
			get
			{
				return this.paySubscriptionUpdateReplyField;
			}
			set
			{
				this.paySubscriptionUpdateReplyField = value;
			}
		}
		public PaySubscriptionEventUpdateReply paySubscriptionEventUpdateReply
		{
			get
			{
				return this.paySubscriptionEventUpdateReplyField;
			}
			set
			{
				this.paySubscriptionEventUpdateReplyField = value;
			}
		}
		public PaySubscriptionRetrieveReply paySubscriptionRetrieveReply
		{
			get
			{
				return this.paySubscriptionRetrieveReplyField;
			}
			set
			{
				this.paySubscriptionRetrieveReplyField = value;
			}
		}
		public PayPalPaymentReply payPalPaymentReply
		{
			get
			{
				return this.payPalPaymentReplyField;
			}
			set
			{
				this.payPalPaymentReplyField = value;
			}
		}
		public PayPalCreditReply payPalCreditReply
		{
			get
			{
				return this.payPalCreditReplyField;
			}
			set
			{
				this.payPalCreditReplyField = value;
			}
		}
		public VoidReply voidReply
		{
			get
			{
				return this.voidReplyField;
			}
			set
			{
				this.voidReplyField = value;
			}
		}
		public PinlessDebitReply pinlessDebitReply
		{
			get
			{
				return this.pinlessDebitReplyField;
			}
			set
			{
				this.pinlessDebitReplyField = value;
			}
		}
		public PinlessDebitValidateReply pinlessDebitValidateReply
		{
			get
			{
				return this.pinlessDebitValidateReplyField;
			}
			set
			{
				this.pinlessDebitValidateReplyField = value;
			}
		}
		public PayPalButtonCreateReply payPalButtonCreateReply
		{
			get
			{
				return this.payPalButtonCreateReplyField;
			}
			set
			{
				this.payPalButtonCreateReplyField = value;
			}
		}
		public PayPalPreapprovedPaymentReply payPalPreapprovedPaymentReply
		{
			get
			{
				return this.payPalPreapprovedPaymentReplyField;
			}
			set
			{
				this.payPalPreapprovedPaymentReplyField = value;
			}
		}
		public PayPalPreapprovedUpdateReply payPalPreapprovedUpdateReply
		{
			get
			{
				return this.payPalPreapprovedUpdateReplyField;
			}
			set
			{
				this.payPalPreapprovedUpdateReplyField = value;
			}
		}
		public RiskUpdateReply riskUpdateReply
		{
			get
			{
				return this.riskUpdateReplyField;
			}
			set
			{
				this.riskUpdateReplyField = value;
			}
		}
		public DecisionReply decisionReply
		{
			get
			{
				return this.decisionReplyField;
			}
			set
			{
				this.decisionReplyField = value;
			}
		}
		public XmlElement reserved
		{
			get
			{
				return this.reservedField;
			}
			set
			{
				this.reservedField = value;
			}
		}
	}
}
