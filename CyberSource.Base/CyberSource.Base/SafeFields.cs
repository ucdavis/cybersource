using System;
using System.Collections;
using System.Text;
namespace CyberSource.Base
{
	public class SafeFields
	{
		public enum MessageType
		{
			REQUEST,
			REPLY
		}
		private enum FieldNameState
		{
			Boundary,
			NonIndex,
			PossibleIndex,
			Done
		}
		internal const string REQUEST_MESSAGE = "requestMessage";
		internal const string REPLY_MESSAGE = "replyMessage";
		private const char UNDERSCORE = '_';
		private static Hashtable safeTable;
		static SafeFields()
		{
			SafeFields.safeTable = new Hashtable();
			SafeFields.safeTable.Add("item", "unitPrice quantity productCode productName productSKU productRisk taxAmount cityOverrideAmount cityOverrideRate countyOverrideAmount countyOverrideRate districtOverrideAmount districtOverrideRate stateOverrideAmount stateOverrideRate countryOverrideAmount countryOverrideRate orderAcceptanceCity orderAcceptanceCounty orderAcceptanceCountry orderAcceptanceState orderAcceptancePostalCode orderOriginCity orderOriginCounty orderOeriginCountry orderOriginState orderOriginPostalCode shipFromCity shipFromCounty shipFromCountry shipFromState shipFromPostalCode export noExport nationalTax vatRate sellerRegistration buyerRegistration middlemanRegistration pointOfTitleTransfer giftCategory timeCategory hostHedge timeHedge velocityHedge unitOfMeasure taxRate totalAmount discountAmount discountRate commodityCode grossNetIndicator taxTypeApplied discountIndicator alternateTaxID");
			SafeFields.safeTable.Add("ccAuthService", "run cavv commerceIndicator eciRaw xid reconcilationID avsLevel fxQuoteID returnAuthRecord authType verbalAuthCode billPayment");
			SafeFields.safeTable.Add("ccCaptureService", "run authType verbalAuthCode authRequestID transactionToken reconciliationID partialPaymentID purchasingLevel industryDataType");
			SafeFields.safeTable.Add("ccCreditService", "run captureRequestID transactionToken reconciliationID partialPaymentID purchasingLevel industryDataType commerceIndicator billPayment");
			SafeFields.safeTable.Add("ccAuthReversalService", "run authRequestID transactionToken");
			SafeFields.safeTable.Add("ecDebitService", "run paymentMode referenceNumber settlementMethod transactionToken verificationLevel partialPaymentID commerceIndicator");
			SafeFields.safeTable.Add("ecCreditService", "run referenceNumber settlementMethod transactionToken debitRequestID partialPaymentID commerceIndicator");
			SafeFields.safeTable.Add("payerAuthEnrollService", "run httpAccept httpUserAgent merchantName merchantURL purchaseDescription purchaseTime countryCode acquirerBin merchantID");
			SafeFields.safeTable.Add("payerAuthValidateService", "run signedPARes");
			SafeFields.safeTable.Add("taxService", "run nexus noNexus orderAcceptanceCity orderAcceptanceCounty orderAcceptanceCountry orderAcceptanceState orderAcceptancePostalCode orderOriginCity orderOriginCounty orderOriginCountry orderOriginState orderOriginPostalCode sellerRegistration buyerRegistration middlemanRegistration pointOfTitleTransfer");
			SafeFields.safeTable.Add("afsService", "run avsCode cvCode disableAVSScoring");
			SafeFields.safeTable.Add("davService", "run");
			SafeFields.safeTable.Add("exportService", "run addressOperator addressWeight companyWeight nameWeight");
			SafeFields.safeTable.Add("fxRatesService", "run");
			SafeFields.safeTable.Add("bankTransferService", "run");
			SafeFields.safeTable.Add("bankTransferRefundService", "run bankTransferRequestID reconciliationID");
			SafeFields.safeTable.Add("directDebitService", "run dateCollect directDebitText authorizationID transactionType directDebitType validateRequestID");
			SafeFields.safeTable.Add("directDebitRefundService", "run directDebitRequestID reconciliationID");
			SafeFields.safeTable.Add("directDebitValidateService", "run directDebitValidateText");
			SafeFields.safeTable.Add("paySubscriptionCreateService", "run paymentRequestID disableAutoAuth");
			SafeFields.safeTable.Add("paySubscriptionUpdateService", "run");
			SafeFields.safeTable.Add("paySubscriptionEventUpdateService", "run action");
			SafeFields.safeTable.Add("paySubscriptionRetrieveService", "run");
			SafeFields.safeTable.Add("payPalPaymentService", "run cancelURL successURL reconciliationID");
			SafeFields.safeTable.Add("payPalCreditService", "run payPalPaymentRequestID reconciliationID");
			SafeFields.safeTable.Add("voidService", "run voidRequestID");
			SafeFields.safeTable.Add("pinlessDebitService", "run reconciliationID commerceIndicator");
			SafeFields.safeTable.Add("pinlessDebitValidateService", "run");
			SafeFields.safeTable.Add("payPalButtonCreateService", "run buttonType reconciliationID");
			SafeFields.safeTable.Add("payPalPreapprovedPaymentService", "run reconciliationID");
			SafeFields.safeTable.Add("payPalPreapprovedUpdateService", "run reconciliationID");
			SafeFields.safeTable.Add("riskUpdateService", "run actionCode recordID negativeAddress_city negativeAddress_state negativeAddress_postalCode negativeAddress_country");
			SafeFields.safeTable.Add("invoiceHeader", "merchantDescriptor merchantDescriptorContact isGift returnsAccepted tenderType merchantVATRegistrationNumber purchaserOrderDate purchaserVATRegistrationNumber vatInvoiceReferenceNumber summaryCommodityCode supplierOrderReference userPO costCenter purchaserCode taxable amexDataTAA1 amexDataTAA2 amexDataTAA3 amexDataTAA4 invoiceDate");
			SafeFields.safeTable.Add("businessRules", "ignoreAVSResult ignoreCVResult ignoreDAVResult ignoreExportResult ignoreValidateResult declineAVSFlags scoreThreshold");
			SafeFields.safeTable.Add("billTo", "title suffix city county state postalCode country company ipAddress ipNetworkAddress hostname domainName driversLicenseState customerID httpBrowserType httpBrowserCookiesAccepted");
			SafeFields.safeTable.Add("shipTo", "title suffix city county state postalCode country company shippingMethod");
			SafeFields.safeTable.Add("shipFrom", "title suffix city county state postalCode country company");
			SafeFields.safeTable.Add("card", "bin");
			SafeFields.safeTable.Add("check", "");
			SafeFields.safeTable.Add("bml", "customerBillingAddressChange customerEmailChange customerHasCheckingAccount CustomerHasSavingsAccount customerPasswordChange customerPhoneChange customerRegistrationDate customerTypeFlag grossHouseholdIncome householdIncomeCurrency itemCategory merchantPromotionCode preapprovalNumber productDeliveryTypeIndicator residenceStatus tcVersion yearsAtCurrentResidence yearsWithCurrentEmployer employerCity employerCompanyName employerCountry employerPhoneType employerState employerPostalCode shipToPhoneType billToPhoneType");
			SafeFields.safeTable.Add("otherTax", "vatTaxAmount vatTaxRate alternateTaxAmount alternateTaxIndicator alternateTaxID localTaxAmount localTaxIndicator nationalTaxAmount nationalTaxIndicator");
			SafeFields.safeTable.Add("purchaseTotals", "currency discountAmount taxAmount dutyAmount grandTotalAmount freightAmount");
			SafeFields.safeTable.Add("fundingTotals", "currency grandTotalAmount");
			SafeFields.safeTable.Add("gecc", "saleType planNumber sequenceNumber promotionEndDate promotionPlan line");
			SafeFields.safeTable.Add("ucaf", "authenticationData collectionIndicator");
			SafeFields.safeTable.Add("fundTransfer", "");
			SafeFields.safeTable.Add("bankInfo", "bankCode name address city country branchCode swiftCode sortCode");
			SafeFields.safeTable.Add("recurringSubscriptionInfo", "status amount numberOfPayments numberOfPaymentsToAdd automaticRenew frequency startDate endDate approvalRequired event_amount event_approvedBy event_number billPayment");
			SafeFields.safeTable.Add("subscription", "title paymentMethod");
			SafeFields.safeTable.Add("decisionManager", "enabled profile");
			SafeFields.safeTable.Add("batch", "batchID recordID");
			SafeFields.safeTable.Add("payPal", "");
			SafeFields.safeTable.Add("jpo", "paymentMethod bonusAmount bonuses installments");
			SafeFields.safeTable.Add("requestMessage", "merchantID merchantReferenceCode clientLibrary clientLibraryVersion clientEnvironment clientSecurityLibraryVersion clientApplication clientApplicationVersion clientApplicationUser comments");
			SafeFields.safeTable.Add("ccAuthReply", "reasonCode amount avsCode avsCodeRaw cvCode cvCodeRaw authorizedDateTime processorResponse authFactorCode reconciliationID transactionToken fundingTotals_currency fundingTotals_grandTotalAmount fxQuoteID fxQuoteRate fxQuoteType fxQuoteExpirationDateTime");
			SafeFields.safeTable.Add("ccCaptureReply", "reasonCode requestDateTime amount reconciliationID transactionToken fundingTotals_currency fundingTotals_grandTotalAmount fxQuoteID fxQuoteRate fxQuoteType fxQuoteExpirationDateTime purchasingLevel3Enabled enhancedDataEnabled");
			SafeFields.safeTable.Add("ccCreditReply", "reasonCode requestDateTime amount reconciliationID transactionToken purchasingLevel3Enabled enhancedDataEnabled");
			SafeFields.safeTable.Add("ccAuthReversalReply", "reasonCode amount processorResponse requestDateTime transactionToken");
			SafeFields.safeTable.Add("ecDebitReply", "reasonCode settlementMethod requestDateTime amount verificationLevel reconciliationID processorResponse transactionToken avsCode avsCodeRaw");
			SafeFields.safeTable.Add("ecCreditReply", "reasonCode settlementMethod requestDateTime amount reconciliationID processorResponse transactionToken");
			SafeFields.safeTable.Add("payerAuthEnrollReply", "reasonCode acsURL commerceIndicator paReq proxyPAN xid proofXML ucafCollectionIndicator");
			SafeFields.safeTable.Add("payerAuthValidateReply", "reasonCode authenticationResult authenticationStatusMessage cavv commerceIndicator eci eciRaw xid ucafAuthenticationData ucafCollectionIndicator");
			SafeFields.safeTable.Add("taxReply", "reasonCode currency grandTotalAmount totalCityTaxAmount city totalCountyTaxAmount county totalDistrictTaxAmount totalStateTaxAmount state totalTaxAmount postalCode geocode item_cityTaxAmount item_countyTaxAmount item_districtTaxAmount item_stateTaxAmount item_totalTaxAmount");
			SafeFields.safeTable.Add("afsReply", "reasonCode afsResult hostSeverity consumerLocalTime afsFactorCode addressInfoCode hotlistInfoCode internetInfoCode phoneInfoCode suspiciousInfoCode velocityInfoCode");
			SafeFields.safeTable.Add("davReply", "reasonCode addressType apartmentInfo barCode barCodeCheckDigit cityInfo countryInfo directionalInfo lvrInfo matchScore standardizedCity standardizedCounty standardizedCSP standardizedState standardizedPostalCode standardizedCountry standardizedISOCountry stateInfo streetInfo suffixInfo postalCodeInfo overallInfo usInfo caInfo intlInfo usErrorInfo caErrorInfo intlErrorInfo");
			SafeFields.safeTable.Add("deniedPartiesMatch", "list");
			SafeFields.safeTable.Add("exportReply", "reasonCode ipCountryConfidence");
			SafeFields.safeTable.Add("fxRatesReply", "reasonCode quote_id quote_rate quote_type quote_expirationDateTime quote_currency quote_fundingCurrency quote_receivedDateTime");
			SafeFields.safeTable.Add("bankTransferReply", "reasonCode amount bankName bankCity bankCountry paymentReference processorResponse bankSwiftCode bankSpecialID requestDateTime reconciliationID");
			SafeFields.safeTable.Add("bankTransferRefundReply", "reasonCode amount requestDateTime reconciliationID processorResponse");
			SafeFields.safeTable.Add("directDebitReply", "reasonCode amount requestDateTime reconciliationID processorResponse");
			SafeFields.safeTable.Add("directDebitValidateReply", "reasonCode amount requestDateTime reconciliationID processorResponse");
			SafeFields.safeTable.Add("directDebitRefundReply", "reasonCode amount requestDateTime reconciliationID processorResponse");
			SafeFields.safeTable.Add("paySubscriptionCreateReply", "reasonCode");
			SafeFields.safeTable.Add("paySubscriptionUpdateReply", "reasonCode");
			SafeFields.safeTable.Add("paySubscriptionEventUpdateReply", "reasonCode");
			SafeFields.safeTable.Add("paySubscriptionRetrieveReply", "reasonCode approvalRequired automaticRenew cardType checkAccountType city comments companyName country currency customerAccountID endDate frequency merchantReferenceCode paymentMethod paymentsRemaining postalCode recurringAmount setupAmount startDate state status title totalPayments shipToCity shipToState shipToCompany shipToCountry billPayment merchantDefinedDataField1 merchantDefinedDataField2 merchantDefinedDateField3 merchantDefinedDataField4");
			SafeFields.safeTable.Add("payPalPaymentReply", "reasonCode amount requestDateTime reconciliationID");
			SafeFields.safeTable.Add("payPalCreditReply", "reasonCode amount requestDateTime reconciliationID processorResponse");
			SafeFields.safeTable.Add("voidReply", "reasonCode requestDateTime amount currency");
			SafeFields.safeTable.Add("pinlessDebitReply", "reasonCode amount requestDateTime processorResponse receiptNumber reconciliationID");
			SafeFields.safeTable.Add("pinlessDebitValidateReply", "reasonCode status requestDateTime");
			SafeFields.safeTable.Add("payPalButtonCreateReply", "reasonCode encryptedFormData requestDateTime reconciliationID buttonType");
			SafeFields.safeTable.Add("payPalPreapprovedPaymentReply", "reasonCode requestDateTime reconciliationID payerStatus transactionType feeAmount payerCountry pendingReason paymentStatus mpStatus payerBusiness desc mpMax paymentType paymentDate paymentGrossAmount settleAmount taxAmount exchangeRate paymentSourceID");
			SafeFields.safeTable.Add("payPalPreapprovedUpdateReply", "reasonCode requestDateTime reconciliationID payerStatus payerCountry mpStatus payerBusiness desc mpMax paymentSourceID");
			SafeFields.safeTable.Add("riskUpdateReply", "reasonCode");
			SafeFields.safeTable.Add("decisionReply", "activeProfileReply_selectedBy activeProfileReply_name activeProfileReply_destinationQueue activeProfileReply_rulesTriggered_ruleResultItem_name activeProfileReply_rulesTriggered_ruleResultItem_decision activeProfileReply_rulesTriggered_ruleResultItem_evaluation activeProfileReply_rulesTriggered_ruleResultItem_ruleID");
			SafeFields.safeTable.Add("replyMessage", "merchantReferenceCode requestID decision reasonCode missingField invalidField requestToken");
			SafeFields.safeTable.Add("airlineData", "agentCode agentName ticketIssuerCity ticketIssuerState ticketIssuerPostalCode ticketIssuerCountry ticketIssuerCode ticketIssuerName ticketNumber checkDigit restrictedTicketIndicator transactionType extendedPaymentCode carrierName customerCode documentType documentNumber documentNumberOfParts chargeDetails bookingReference leg_carrierCode leg_flightNumber leg_originatingAirportCode leg_class leg_stopoverCode leg_departureDate leg_destination leg_fareBasis leg_departTax");
			SafeFields.safeTable.Add("pos", "entryMode cardPresent terminalCapability terminalID terminalType terminalLocation transactionSecurity catLevel conditionCode");
			SafeFields.safeTable.Add("merchantDefinedData", "field1 field2 field3 field4");
		}
		public static bool IsSafe(SafeFields.MessageType type, string field)
		{
			field = SafeFields.RemoveIndices(field);
			int pos = field.IndexOf('_');
			if (pos != -1)
			{
				string parent = field.Substring(0, pos);
				string child = field.Substring(pos + 1);
				return SafeFields.IsSafe(parent, child);
			}
			return SafeFields.IsSafe((type == SafeFields.MessageType.REQUEST) ? "requestMessage" : "replyMessage", field);
		}
		public static bool IsSafe(string parent, string child)
		{
			string list = (string)SafeFields.safeTable[parent];
			return list != null && list.Contains(child);
		}
		public static string RemoveIndices(string field)
		{
			int len = (field != null) ? field.Length : 0;
			if (len == 0)
			{
				return field;
			}
			int indexStart = 0;
			SafeFields.FieldNameState state = SafeFields.FieldNameState.Boundary;
			StringBuilder sb = new StringBuilder();
			int src = 0;
			while (state != SafeFields.FieldNameState.Done)
			{
				bool isPastEnd = src >= len;
				char ch = (!isPastEnd) ? field[src] : '_';
				bool isDigit = char.IsDigit(ch);
				switch (state)
				{
				case SafeFields.FieldNameState.Boundary:
					if (isDigit)
					{
						state = SafeFields.FieldNameState.PossibleIndex;
						indexStart = sb.Length;
						goto IL_C1;
					}
					state = SafeFields.FieldNameState.NonIndex;
					goto IL_C1;
				case SafeFields.FieldNameState.NonIndex:
					if (ch == '_')
					{
						state = SafeFields.FieldNameState.Boundary;
						goto IL_C1;
					}
					goto IL_C1;
				case SafeFields.FieldNameState.PossibleIndex:
					if (ch == '_')
					{
						if (indexStart == 0)
						{
							sb.Remove(0, sb.Length);
							if (!isPastEnd)
							{
								break;
							}
						}
						else
						{
							sb.Remove(indexStart - 1, sb.Length - indexStart + 1);
						}
						state = SafeFields.FieldNameState.Boundary;
						goto IL_C1;
					}
					if (!isDigit)
					{
						state = SafeFields.FieldNameState.NonIndex;
						goto IL_C1;
					}
					goto IL_C1;
				default:
					goto IL_C1;
				}
				IL_D2:
				src++;
				continue;
				IL_C1:
				if (!isPastEnd)
				{
					sb.Append(ch);
					goto IL_D2;
				}
				state = SafeFields.FieldNameState.Done;
				goto IL_D2;
			}
			return sb.ToString();
		}
	}
}
