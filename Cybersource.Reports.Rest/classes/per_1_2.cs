﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class Report {
    
    private Request[] requestsField;
    
    private string nameField;
    
    private string versionField;
    
    private string merchantIDField;
    
    private string reportStartDateField;
    
    private string reportEndDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Request", IsNullable=false)]
    public Request[] Requests {
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string MerchantID {
        get {
            return this.merchantIDField;
        }
        set {
            this.merchantIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string ReportStartDate {
        get {
            return this.reportStartDateField;
        }
        set {
            this.reportStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class Request {
    
    private BankTransfer[] bankTransferField;
    
    private CreditCard[] creditCardField;
    
    private DirectDebit[] directDebitField;
    
    private Check[] checkField;
    
    private PayPal[] payPalField;
    
    private Payment[] paymentField;
    
    private string requestIDField;
    
    private string transactionDateField;
    
    private string merchantReferenceNumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BankTransfer")]
    public BankTransfer[] BankTransfer {
        get {
            return this.bankTransferField;
        }
        set {
            this.bankTransferField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CreditCard")]
    public CreditCard[] CreditCard {
        get {
            return this.creditCardField;
        }
        set {
            this.creditCardField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DirectDebit")]
    public DirectDebit[] DirectDebit {
        get {
            return this.directDebitField;
        }
        set {
            this.directDebitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Check")]
    public Check[] Check {
        get {
            return this.checkField;
        }
        set {
            this.checkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PayPal")]
    public PayPal[] PayPal {
        get {
            return this.payPalField;
        }
        set {
            this.payPalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Payment")]
    public Payment[] Payment {
        get {
            return this.paymentField;
        }
        set {
            this.paymentField = value;
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
    public string TransactionDate {
        get {
            return this.transactionDateField;
        }
        set {
            this.transactionDateField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class BankTransfer {
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string processorMessageField;
    
    private string exceptionField;
    
    private string boletoNumberField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string Exception {
        get {
            return this.exceptionField;
        }
        set {
            this.exceptionField = value;
        }
    }
    
    /// <remarks/>
    public string BoletoNumber {
        get {
            return this.boletoNumberField;
        }
        set {
            this.boletoNumberField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class CreditCard {
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string processorMessageField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class DirectDebit {
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string processorMessageField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class Check {
    
    private string debitIndicatorField;
    
    private string transactionIDField;
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string feeCurrencyCodeField;
    
    private string feeAmountField;
    
    private string processorMessageField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
    /// <remarks/>
    public string DebitIndicator {
        get {
            return this.debitIndicatorField;
        }
        set {
            this.debitIndicatorField = value;
        }
    }
    
    /// <remarks/>
    public string TransactionID {
        get {
            return this.transactionIDField;
        }
        set {
            this.transactionIDField = value;
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string FeeCurrencyCode {
        get {
            return this.feeCurrencyCodeField;
        }
        set {
            this.feeCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string FeeAmount {
        get {
            return this.feeAmountField;
        }
        set {
            this.feeAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class PayPal {
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string feeCurrencyCodeField;
    
    private string feeAmountField;
    
    private string processorMessageField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string FeeCurrencyCode {
        get {
            return this.feeCurrencyCodeField;
        }
        set {
            this.feeCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string FeeAmount {
        get {
            return this.feeAmountField;
        }
        set {
            this.feeAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
public partial class Payment {
    
    private string transactionReferenceNumberField;
    
    private string merchantCurrencyCodeField;
    
    private string merchantAmountField;
    
    private string consumerCurrencyCodeField;
    
    private string consumerAmountField;
    
    private string feeCurrencyCodeField;
    
    private string feeAmountField;
    
    private string processorMessageField;
    
    private string paymentTypeDescriptionField;
    
    private string eventField;
    
    private string eventDateField;
    
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
    public string MerchantCurrencyCode {
        get {
            return this.merchantCurrencyCodeField;
        }
        set {
            this.merchantCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string MerchantAmount {
        get {
            return this.merchantAmountField;
        }
        set {
            this.merchantAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerCurrencyCode {
        get {
            return this.consumerCurrencyCodeField;
        }
        set {
            this.consumerCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string ConsumerAmount {
        get {
            return this.consumerAmountField;
        }
        set {
            this.consumerAmountField = value;
        }
    }
    
    /// <remarks/>
    public string FeeCurrencyCode {
        get {
            return this.feeCurrencyCodeField;
        }
        set {
            this.feeCurrencyCodeField = value;
        }
    }
    
    /// <remarks/>
    public string FeeAmount {
        get {
            return this.feeAmountField;
        }
        set {
            this.feeAmountField = value;
        }
    }
    
    /// <remarks/>
    public string ProcessorMessage {
        get {
            return this.processorMessageField;
        }
        set {
            this.processorMessageField = value;
        }
    }
    
    /// <remarks/>
    public string PaymentTypeDescription {
        get {
            return this.paymentTypeDescriptionField;
        }
        set {
            this.paymentTypeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
    public string EventDate {
        get {
            return this.eventDateField;
        }
        set {
            this.eventDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/per_1_2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/per_1_2", IsNullable=false)]
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
