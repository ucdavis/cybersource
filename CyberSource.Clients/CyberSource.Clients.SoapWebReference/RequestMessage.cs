using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class RequestMessage
	{
		private string merchantIDField;
		private string merchantReferenceCodeField;
		private string clientLibraryField;
		private string clientLibraryVersionField;
		private string clientEnvironmentField;
		private string clientSecurityLibraryVersionField;
		private string clientApplicationField;
		private string clientApplicationVersionField;
		private string clientApplicationUserField;
		private string commentsField;
		private InvoiceHeader invoiceHeaderField;
		private BillTo billToField;
		private ShipTo shipToField;
		private ShipFrom shipFromField;
		private Item[] itemField;
		private PurchaseTotals purchaseTotalsField;
		private FundingTotals fundingTotalsField;
		private Pos posField;
		private Installment installmentField;
		private Card cardField;
		private Check checkField;
		private BML bmlField;
		private GECC geccField;
		private UCAF ucafField;
		private FundTransfer fundTransferField;
		private BankInfo bankInfoField;
		private Subscription subscriptionField;
		private RecurringSubscriptionInfo recurringSubscriptionInfoField;
		private DecisionManager decisionManagerField;
		private OtherTax otherTaxField;
		private PayPal paypalField;
		private MerchantDefinedData merchantDefinedDataField;
		private MerchantSecureData merchantSecureDataField;
		private JPO jpoField;
		private CCAuthService ccAuthServiceField;
		private CCCaptureService ccCaptureServiceField;
		private CCCreditService ccCreditServiceField;
		private CCAuthReversalService ccAuthReversalServiceField;
		private ECDebitService ecDebitServiceField;
		private ECCreditService ecCreditServiceField;
		private PayerAuthEnrollService payerAuthEnrollServiceField;
		private PayerAuthValidateService payerAuthValidateServiceField;
		private TaxService taxServiceField;
		private AFSService afsServiceField;
		private DAVService davServiceField;
		private ExportService exportServiceField;
		private FXRatesService fxRatesServiceField;
		private BankTransferService bankTransferServiceField;
		private BankTransferRefundService bankTransferRefundServiceField;
		private BankTransferRealTimeService bankTransferRealTimeServiceField;
		private DirectDebitMandateService directDebitMandateServiceField;
		private DirectDebitService directDebitServiceField;
		private DirectDebitRefundService directDebitRefundServiceField;
		private DirectDebitValidateService directDebitValidateServiceField;
		private PaySubscriptionCreateService paySubscriptionCreateServiceField;
		private PaySubscriptionUpdateService paySubscriptionUpdateServiceField;
		private PaySubscriptionEventUpdateService paySubscriptionEventUpdateServiceField;
		private PaySubscriptionRetrieveService paySubscriptionRetrieveServiceField;
		private PayPalPaymentService payPalPaymentServiceField;
		private PayPalCreditService payPalCreditServiceField;
		private VoidService voidServiceField;
		private BusinessRules businessRulesField;
		private PinlessDebitService pinlessDebitServiceField;
		private PinlessDebitValidateService pinlessDebitValidateServiceField;
		private Batch batchField;
		private AirlineData airlineDataField;
		private PayPalButtonCreateService payPalButtonCreateServiceField;
		private PayPalPreapprovedPaymentService payPalPreapprovedPaymentServiceField;
		private PayPalPreapprovedUpdateService payPalPreapprovedUpdateServiceField;
		private RiskUpdateService riskUpdateServiceField;
		private RequestReserved[] reservedField;
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
		public string clientLibrary
		{
			get
			{
				return this.clientLibraryField;
			}
			set
			{
				this.clientLibraryField = value;
			}
		}
		public string clientLibraryVersion
		{
			get
			{
				return this.clientLibraryVersionField;
			}
			set
			{
				this.clientLibraryVersionField = value;
			}
		}
		public string clientEnvironment
		{
			get
			{
				return this.clientEnvironmentField;
			}
			set
			{
				this.clientEnvironmentField = value;
			}
		}
		public string clientSecurityLibraryVersion
		{
			get
			{
				return this.clientSecurityLibraryVersionField;
			}
			set
			{
				this.clientSecurityLibraryVersionField = value;
			}
		}
		public string clientApplication
		{
			get
			{
				return this.clientApplicationField;
			}
			set
			{
				this.clientApplicationField = value;
			}
		}
		public string clientApplicationVersion
		{
			get
			{
				return this.clientApplicationVersionField;
			}
			set
			{
				this.clientApplicationVersionField = value;
			}
		}
		public string clientApplicationUser
		{
			get
			{
				return this.clientApplicationUserField;
			}
			set
			{
				this.clientApplicationUserField = value;
			}
		}
		public string comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
			}
		}
		public InvoiceHeader invoiceHeader
		{
			get
			{
				return this.invoiceHeaderField;
			}
			set
			{
				this.invoiceHeaderField = value;
			}
		}
		public BillTo billTo
		{
			get
			{
				return this.billToField;
			}
			set
			{
				this.billToField = value;
			}
		}
		public ShipTo shipTo
		{
			get
			{
				return this.shipToField;
			}
			set
			{
				this.shipToField = value;
			}
		}
		public ShipFrom shipFrom
		{
			get
			{
				return this.shipFromField;
			}
			set
			{
				this.shipFromField = value;
			}
		}
		[XmlElement("item")]
		public Item[] item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
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
		public FundingTotals fundingTotals
		{
			get
			{
				return this.fundingTotalsField;
			}
			set
			{
				this.fundingTotalsField = value;
			}
		}
		public Pos pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}
		public Installment installment
		{
			get
			{
				return this.installmentField;
			}
			set
			{
				this.installmentField = value;
			}
		}
		public Card card
		{
			get
			{
				return this.cardField;
			}
			set
			{
				this.cardField = value;
			}
		}
		public Check check
		{
			get
			{
				return this.checkField;
			}
			set
			{
				this.checkField = value;
			}
		}
		public BML bml
		{
			get
			{
				return this.bmlField;
			}
			set
			{
				this.bmlField = value;
			}
		}
		public GECC gecc
		{
			get
			{
				return this.geccField;
			}
			set
			{
				this.geccField = value;
			}
		}
		public UCAF ucaf
		{
			get
			{
				return this.ucafField;
			}
			set
			{
				this.ucafField = value;
			}
		}
		public FundTransfer fundTransfer
		{
			get
			{
				return this.fundTransferField;
			}
			set
			{
				this.fundTransferField = value;
			}
		}
		public BankInfo bankInfo
		{
			get
			{
				return this.bankInfoField;
			}
			set
			{
				this.bankInfoField = value;
			}
		}
		public Subscription subscription
		{
			get
			{
				return this.subscriptionField;
			}
			set
			{
				this.subscriptionField = value;
			}
		}
		public RecurringSubscriptionInfo recurringSubscriptionInfo
		{
			get
			{
				return this.recurringSubscriptionInfoField;
			}
			set
			{
				this.recurringSubscriptionInfoField = value;
			}
		}
		public DecisionManager decisionManager
		{
			get
			{
				return this.decisionManagerField;
			}
			set
			{
				this.decisionManagerField = value;
			}
		}
		public OtherTax otherTax
		{
			get
			{
				return this.otherTaxField;
			}
			set
			{
				this.otherTaxField = value;
			}
		}
		public PayPal paypal
		{
			get
			{
				return this.paypalField;
			}
			set
			{
				this.paypalField = value;
			}
		}
		public MerchantDefinedData merchantDefinedData
		{
			get
			{
				return this.merchantDefinedDataField;
			}
			set
			{
				this.merchantDefinedDataField = value;
			}
		}
		public MerchantSecureData merchantSecureData
		{
			get
			{
				return this.merchantSecureDataField;
			}
			set
			{
				this.merchantSecureDataField = value;
			}
		}
		public JPO jpo
		{
			get
			{
				return this.jpoField;
			}
			set
			{
				this.jpoField = value;
			}
		}
		public CCAuthService ccAuthService
		{
			get
			{
				return this.ccAuthServiceField;
			}
			set
			{
				this.ccAuthServiceField = value;
			}
		}
		public CCCaptureService ccCaptureService
		{
			get
			{
				return this.ccCaptureServiceField;
			}
			set
			{
				this.ccCaptureServiceField = value;
			}
		}
		public CCCreditService ccCreditService
		{
			get
			{
				return this.ccCreditServiceField;
			}
			set
			{
				this.ccCreditServiceField = value;
			}
		}
		public CCAuthReversalService ccAuthReversalService
		{
			get
			{
				return this.ccAuthReversalServiceField;
			}
			set
			{
				this.ccAuthReversalServiceField = value;
			}
		}
		public ECDebitService ecDebitService
		{
			get
			{
				return this.ecDebitServiceField;
			}
			set
			{
				this.ecDebitServiceField = value;
			}
		}
		public ECCreditService ecCreditService
		{
			get
			{
				return this.ecCreditServiceField;
			}
			set
			{
				this.ecCreditServiceField = value;
			}
		}
		public PayerAuthEnrollService payerAuthEnrollService
		{
			get
			{
				return this.payerAuthEnrollServiceField;
			}
			set
			{
				this.payerAuthEnrollServiceField = value;
			}
		}
		public PayerAuthValidateService payerAuthValidateService
		{
			get
			{
				return this.payerAuthValidateServiceField;
			}
			set
			{
				this.payerAuthValidateServiceField = value;
			}
		}
		public TaxService taxService
		{
			get
			{
				return this.taxServiceField;
			}
			set
			{
				this.taxServiceField = value;
			}
		}
		public AFSService afsService
		{
			get
			{
				return this.afsServiceField;
			}
			set
			{
				this.afsServiceField = value;
			}
		}
		public DAVService davService
		{
			get
			{
				return this.davServiceField;
			}
			set
			{
				this.davServiceField = value;
			}
		}
		public ExportService exportService
		{
			get
			{
				return this.exportServiceField;
			}
			set
			{
				this.exportServiceField = value;
			}
		}
		public FXRatesService fxRatesService
		{
			get
			{
				return this.fxRatesServiceField;
			}
			set
			{
				this.fxRatesServiceField = value;
			}
		}
		public BankTransferService bankTransferService
		{
			get
			{
				return this.bankTransferServiceField;
			}
			set
			{
				this.bankTransferServiceField = value;
			}
		}
		public BankTransferRefundService bankTransferRefundService
		{
			get
			{
				return this.bankTransferRefundServiceField;
			}
			set
			{
				this.bankTransferRefundServiceField = value;
			}
		}
		public BankTransferRealTimeService bankTransferRealTimeService
		{
			get
			{
				return this.bankTransferRealTimeServiceField;
			}
			set
			{
				this.bankTransferRealTimeServiceField = value;
			}
		}
		public DirectDebitMandateService directDebitMandateService
		{
			get
			{
				return this.directDebitMandateServiceField;
			}
			set
			{
				this.directDebitMandateServiceField = value;
			}
		}
		public DirectDebitService directDebitService
		{
			get
			{
				return this.directDebitServiceField;
			}
			set
			{
				this.directDebitServiceField = value;
			}
		}
		public DirectDebitRefundService directDebitRefundService
		{
			get
			{
				return this.directDebitRefundServiceField;
			}
			set
			{
				this.directDebitRefundServiceField = value;
			}
		}
		public DirectDebitValidateService directDebitValidateService
		{
			get
			{
				return this.directDebitValidateServiceField;
			}
			set
			{
				this.directDebitValidateServiceField = value;
			}
		}
		public PaySubscriptionCreateService paySubscriptionCreateService
		{
			get
			{
				return this.paySubscriptionCreateServiceField;
			}
			set
			{
				this.paySubscriptionCreateServiceField = value;
			}
		}
		public PaySubscriptionUpdateService paySubscriptionUpdateService
		{
			get
			{
				return this.paySubscriptionUpdateServiceField;
			}
			set
			{
				this.paySubscriptionUpdateServiceField = value;
			}
		}
		public PaySubscriptionEventUpdateService paySubscriptionEventUpdateService
		{
			get
			{
				return this.paySubscriptionEventUpdateServiceField;
			}
			set
			{
				this.paySubscriptionEventUpdateServiceField = value;
			}
		}
		public PaySubscriptionRetrieveService paySubscriptionRetrieveService
		{
			get
			{
				return this.paySubscriptionRetrieveServiceField;
			}
			set
			{
				this.paySubscriptionRetrieveServiceField = value;
			}
		}
		public PayPalPaymentService payPalPaymentService
		{
			get
			{
				return this.payPalPaymentServiceField;
			}
			set
			{
				this.payPalPaymentServiceField = value;
			}
		}
		public PayPalCreditService payPalCreditService
		{
			get
			{
				return this.payPalCreditServiceField;
			}
			set
			{
				this.payPalCreditServiceField = value;
			}
		}
		public VoidService voidService
		{
			get
			{
				return this.voidServiceField;
			}
			set
			{
				this.voidServiceField = value;
			}
		}
		public BusinessRules businessRules
		{
			get
			{
				return this.businessRulesField;
			}
			set
			{
				this.businessRulesField = value;
			}
		}
		public PinlessDebitService pinlessDebitService
		{
			get
			{
				return this.pinlessDebitServiceField;
			}
			set
			{
				this.pinlessDebitServiceField = value;
			}
		}
		public PinlessDebitValidateService pinlessDebitValidateService
		{
			get
			{
				return this.pinlessDebitValidateServiceField;
			}
			set
			{
				this.pinlessDebitValidateServiceField = value;
			}
		}
		public Batch batch
		{
			get
			{
				return this.batchField;
			}
			set
			{
				this.batchField = value;
			}
		}
		public AirlineData airlineData
		{
			get
			{
				return this.airlineDataField;
			}
			set
			{
				this.airlineDataField = value;
			}
		}
		public PayPalButtonCreateService payPalButtonCreateService
		{
			get
			{
				return this.payPalButtonCreateServiceField;
			}
			set
			{
				this.payPalButtonCreateServiceField = value;
			}
		}
		public PayPalPreapprovedPaymentService payPalPreapprovedPaymentService
		{
			get
			{
				return this.payPalPreapprovedPaymentServiceField;
			}
			set
			{
				this.payPalPreapprovedPaymentServiceField = value;
			}
		}
		public PayPalPreapprovedUpdateService payPalPreapprovedUpdateService
		{
			get
			{
				return this.payPalPreapprovedUpdateServiceField;
			}
			set
			{
				this.payPalPreapprovedUpdateServiceField = value;
			}
		}
		public RiskUpdateService riskUpdateService
		{
			get
			{
				return this.riskUpdateServiceField;
			}
			set
			{
				this.riskUpdateServiceField = value;
			}
		}
		[XmlElement("reserved")]
		public RequestReserved[] reserved
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
