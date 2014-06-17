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
namespace Cybersource.Reports.Rest.PaymentBatchDetailReport {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class Report {
        
        private Batches batchesField;
        
        private string nameField;
        
        private string versionField;
        
        private string merchantIDField;
        
        private string reportStartDateField;
        
        private string reportEndDateField;
        
        /// <remarks/>
        public Batches Batches {
            get {
                return this.batchesField;
            }
            set {
                this.batchesField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class Batches {
        
        private Batch[] batchField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Batch")]
        public Batch[] Batch {
            get {
                return this.batchField;
            }
            set {
                this.batchField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class Batch {
        
        private Requests requestsField;
        
        private string batchIDField;
        
        private string batchDateField;
        
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
        public string BatchID {
            get {
                return this.batchIDField;
            }
            set {
                this.batchIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BatchDate {
            get {
                return this.batchDateField;
            }
            set {
                this.batchDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class Request {
        
        private string transactionReferenceNumberField;
        
        private string transactionIdField;
        
        private string paymentMethodField;
        
        private string currencyCodeField;
        
        private string customerIdField;
        
        private string amountField;
        
        private LineItems lineItemsField;
        
        private string applicationField;
        
        private string walletTypeField;
        
        private string requestIDField;
        
        private string merchantReferenceNumberField;
        
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
        public string TransactionId {
            get {
                return this.transactionIdField;
            }
            set {
                this.transactionIdField = value;
            }
        }
        
        /// <remarks/>
        public string PaymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
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
        public string CustomerId {
            get {
                return this.customerIdField;
            }
            set {
                this.customerIdField = value;
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
        
        /// <remarks/>
        public LineItems LineItems {
            get {
                return this.lineItemsField;
            }
            set {
                this.lineItemsField = value;
            }
        }
        
        /// <remarks/>
        public string Application {
            get {
                return this.applicationField;
            }
            set {
                this.applicationField = value;
            }
        }
        
        /// <remarks/>
        public string WalletType {
            get {
                return this.walletTypeField;
            }
            set {
                this.walletTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestID {
            get {
                return this.requestIDField;
            }
            set {
                this.requestIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MerchantReferenceNumber {
            get {
                return this.merchantReferenceNumberField;
            }
            set {
                this.merchantReferenceNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class LineItems {
        
        private LineItem[] lineItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineItem")]
        public LineItem[] LineItem {
            get {
                return this.lineItemField;
            }
            set {
                this.lineItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://ebc.cybersource.com/ebc/reports/dtd/pbdr_1_2.dtd", IsNullable=false)]
    public partial class LineItem {
        
        private string invoiceNumberField;
        
        private string numberField;
        
        /// <remarks/>
        public string InvoiceNumber {
            get {
                return this.invoiceNumberField;
            }
            set {
                this.invoiceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
    }
}
