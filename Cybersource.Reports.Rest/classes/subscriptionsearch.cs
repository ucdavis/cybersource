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
namespace Cybersource.Reports.Rest.SubscriptionSearchReport {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/subscriptionsearch")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/subscriptionsearch", IsNullable=false)]
    public partial class Subscriptions {
        
        private CurrencyTotals currencyTotalsField;
        
        private Subscription[] subscriptionField;
        
        private string startDateField;
        
        private string endDateField;
        
        /// <remarks/>
        public CurrencyTotals CurrencyTotals {
            get {
                return this.currencyTotalsField;
            }
            set {
                this.currencyTotalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subscription")]
        public Subscription[] Subscription {
            get {
                return this.subscriptionField;
            }
            set {
                this.subscriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/subscriptionsearch")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/subscriptionsearch", IsNullable=false)]
    public partial class CurrencyTotals {
        
        private string totalCountField;
        
        private CurrencyTotal[] currencyTotalField;
        
        /// <remarks/>
        public string TotalCount {
            get {
                return this.totalCountField;
            }
            set {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrencyTotal")]
        public CurrencyTotal[] CurrencyTotal {
            get {
                return this.currencyTotalField;
            }
            set {
                this.currencyTotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/subscriptionsearch")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/subscriptionsearch", IsNullable=false)]
    public partial class CurrencyTotal {
        
        private string countField;
        
        private string currencyCodeField;
        
        private string amountField;
        
        /// <remarks/>
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
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
        
        /// <remarks/>
        public string Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/subscriptionsearch")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/subscriptionsearch", IsNullable=false)]
    public partial class Subscription {
        
        private string subscriptionIDField;
        
        private string titleField;
        
        private string billLastNameField;
        
        private string billFirstNameField;
        
        private string subscriptionTypeField;
        
        private string frequencyField;
        
        private string subscriptionAmountField;
        
        private string subscriptionCurrencyCodeField;
        
        private string createDateField;
        
        private string startDateField;
        
        private string endDateField;
        
        private string nextScheduledPaymentDateField;
        
        private string numberOfPaymentsInRetryModeField;
        
        private string cardExpirationDateField;
        
        private string numberOfSuccessfulPaymentsField;
        
        private string amountOfSuccessfulPaymentsField;
        
        private string statusField;
        
        private string originatorMIDField;
        
        private string merchantReferenceCodeField;
        
        /// <remarks/>
        public string SubscriptionID {
            get {
                return this.subscriptionIDField;
            }
            set {
                this.subscriptionIDField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string BillLastName {
            get {
                return this.billLastNameField;
            }
            set {
                this.billLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string BillFirstName {
            get {
                return this.billFirstNameField;
            }
            set {
                this.billFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string SubscriptionType {
            get {
                return this.subscriptionTypeField;
            }
            set {
                this.subscriptionTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Frequency {
            get {
                return this.frequencyField;
            }
            set {
                this.frequencyField = value;
            }
        }
        
        /// <remarks/>
        public string SubscriptionAmount {
            get {
                return this.subscriptionAmountField;
            }
            set {
                this.subscriptionAmountField = value;
            }
        }
        
        /// <remarks/>
        public string SubscriptionCurrencyCode {
            get {
                return this.subscriptionCurrencyCodeField;
            }
            set {
                this.subscriptionCurrencyCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CreateDate {
            get {
                return this.createDateField;
            }
            set {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        public string StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public string EndDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        public string NextScheduledPaymentDate {
            get {
                return this.nextScheduledPaymentDateField;
            }
            set {
                this.nextScheduledPaymentDateField = value;
            }
        }
        
        /// <remarks/>
        public string NumberOfPaymentsInRetryMode {
            get {
                return this.numberOfPaymentsInRetryModeField;
            }
            set {
                this.numberOfPaymentsInRetryModeField = value;
            }
        }
        
        /// <remarks/>
        public string CardExpirationDate {
            get {
                return this.cardExpirationDateField;
            }
            set {
                this.cardExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        public string NumberOfSuccessfulPayments {
            get {
                return this.numberOfSuccessfulPaymentsField;
            }
            set {
                this.numberOfSuccessfulPaymentsField = value;
            }
        }
        
        /// <remarks/>
        public string AmountOfSuccessfulPayments {
            get {
                return this.amountOfSuccessfulPaymentsField;
            }
            set {
                this.amountOfSuccessfulPaymentsField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string OriginatorMID {
            get {
                return this.originatorMIDField;
            }
            set {
                this.originatorMIDField = value;
            }
        }
        
        /// <remarks/>
        public string MerchantReferenceCode {
            get {
                return this.merchantReferenceCodeField;
            }
            set {
                this.merchantReferenceCodeField = value;
            }
        }
    }
}
