﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace Cybersource.Reports.Rest.TransactionExceptionDetailReport {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class Report {
        
        private Requests requestsField;
        
        private string nameField;
        
        private string versionField;
        
        private string merchantIDField;
        
        private string reportStartDateField;
        
        private string reportEndDateField;
        
        /// <remarks/>
        public Requests Requests {
            get {
                return this.requestsField;
            }
            set {
                this.requestsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MerchantID {
            get {
                return this.merchantIDField;
            }
            set {
                this.merchantIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReportStartDate {
            get {
                return this.reportStartDateField;
            }
            set {
                this.reportStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReportEndDate {
            get {
                return this.reportEndDateField;
            }
            set {
                this.reportEndDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class Requests {
        
        private Request[] requestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Request")]
        public Request[] Request {
            get {
                return this.requestField;
            }
            set {
                this.requestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class Request {
        
        private BasicInformation basicInformationField;
        
        private PaymentData paymentDataField;
        
        private PaymentMethod paymentMethodField;
        
        private ErrorInformation errorInformationField;
        
        private BillTo billToField;
        
        private ShipTo shipToField;
        
        /// <remarks/>
        public BasicInformation BasicInformation {
            get {
                return this.basicInformationField;
            }
            set {
                this.basicInformationField = value;
            }
        }
        
        /// <remarks/>
        public PaymentData PaymentData {
            get {
                return this.paymentDataField;
            }
            set {
                this.paymentDataField = value;
            }
        }
        
        /// <remarks/>
        public PaymentMethod PaymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
            }
        }
        
        /// <remarks/>
        public ErrorInformation ErrorInformation {
            get {
                return this.errorInformationField;
            }
            set {
                this.errorInformationField = value;
            }
        }
        
        /// <remarks/>
        public BillTo BillTo {
            get {
                return this.billToField;
            }
            set {
                this.billToField = value;
            }
        }
        
        /// <remarks/>
        public ShipTo ShipTo {
            get {
                return this.shipToField;
            }
            set {
                this.shipToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class BasicInformation {
        
        private string requestIDField;
        
        private string transactionDateField;
        
        private string merchantReferenceNumberField;
        
        private string transactionReferenceNumberField;
        
        private string transactionTypeField;
        
        private string originalRequestIDField;
        
        /// <remarks/>
        public string RequestID {
            get {
                return this.requestIDField;
            }
            set {
                this.requestIDField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
            }
        }
        
        /// <remarks/>
        public string MerchantReferenceNumber {
            get {
                return this.merchantReferenceNumberField;
            }
            set {
                this.merchantReferenceNumberField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionReferenceNumber {
            get {
                return this.transactionReferenceNumberField;
            }
            set {
                this.transactionReferenceNumberField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        public string OriginalRequestID {
            get {
                return this.originalRequestIDField;
            }
            set {
                this.originalRequestIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class PaymentData {
        
        private string amountField;
        
        private string currencyCodeField;
        
        /// <remarks/>
        public string Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string CurrencyCode {
            get {
                return this.currencyCodeField;
            }
            set {
                this.currencyCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class PaymentMethod {
        
        private string accountSuffixField;
        
        private string bankCodeField;
        
        private string bankAccountNameField;
        
        private string expirationMonthField;
        
        private string expirationYearField;
        
        private string cardTypeField;
        
        /// <remarks/>
        public string AccountSuffix {
            get {
                return this.accountSuffixField;
            }
            set {
                this.accountSuffixField = value;
            }
        }
        
        /// <remarks/>
        public string BankCode {
            get {
                return this.bankCodeField;
            }
            set {
                this.bankCodeField = value;
            }
        }
        
        /// <remarks/>
        public string BankAccountName {
            get {
                return this.bankAccountNameField;
            }
            set {
                this.bankAccountNameField = value;
            }
        }
        
        /// <remarks/>
        public string ExpirationMonth {
            get {
                return this.expirationMonthField;
            }
            set {
                this.expirationMonthField = value;
            }
        }
        
        /// <remarks/>
        public string ExpirationYear {
            get {
                return this.expirationYearField;
            }
            set {
                this.expirationYearField = value;
            }
        }
        
        /// <remarks/>
        public string CardType {
            get {
                return this.cardTypeField;
            }
            set {
                this.cardTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class ErrorInformation {
        
        private string paymentProcessorField;
        
        private string actionField;
        
        private string errorCategoryField;
        
        private string errorMessageField;
        
        private string reasonCodeField;
        
        private string processorResponseCodeField;
        
        /// <remarks/>
        public string PaymentProcessor {
            get {
                return this.paymentProcessorField;
            }
            set {
                this.paymentProcessorField = value;
            }
        }
        
        /// <remarks/>
        public string Action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        public string ErrorCategory {
            get {
                return this.errorCategoryField;
            }
            set {
                this.errorCategoryField = value;
            }
        }
        
        /// <remarks/>
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        public string ReasonCode {
            get {
                return this.reasonCodeField;
            }
            set {
                this.reasonCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ProcessorResponseCode {
            get {
                return this.processorResponseCodeField;
            }
            set {
                this.processorResponseCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class BillTo {
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string address1Field;
        
        private string address2Field;
        
        private string cityField;
        
        private string stateField;
        
        private string postalCodeField;
        
        private string countryField;
        
        private string companyNameField;
        
        private string emailField;
        
        private string phoneField;
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string Address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }
        
        /// <remarks/>
        public string Address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/tedr.dtd", IsNullable=false)]
    public partial class ShipTo {
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string address1Field;
        
        private string address2Field;
        
        private string cityField;
        
        private string stateField;
        
        private string postalCodeField;
        
        private string countryField;
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string Address1 {
            get {
                return this.address1Field;
            }
            set {
                this.address1Field = value;
            }
        }
        
        /// <remarks/>
        public string Address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }
}
