using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class InvoiceHeader
	{
		private string merchantDescriptorField;
		private string merchantDescriptorContactField;
		private string isGiftField;
		private string returnsAcceptedField;
		private string tenderTypeField;
		private string merchantVATRegistrationNumberField;
		private string purchaserOrderDateField;
		private string purchaserVATRegistrationNumberField;
		private string vatInvoiceReferenceNumberField;
		private string summaryCommodityCodeField;
		private string supplierOrderReferenceField;
		private string userPOField;
		private string costCenterField;
		private string purchaserCodeField;
		private string taxableField;
		private string amexDataTAA1Field;
		private string amexDataTAA2Field;
		private string amexDataTAA3Field;
		private string amexDataTAA4Field;
		private string invoiceDateField;
		public string merchantDescriptor
		{
			get
			{
				return this.merchantDescriptorField;
			}
			set
			{
				this.merchantDescriptorField = value;
			}
		}
		public string merchantDescriptorContact
		{
			get
			{
				return this.merchantDescriptorContactField;
			}
			set
			{
				this.merchantDescriptorContactField = value;
			}
		}
		public string isGift
		{
			get
			{
				return this.isGiftField;
			}
			set
			{
				this.isGiftField = value;
			}
		}
		public string returnsAccepted
		{
			get
			{
				return this.returnsAcceptedField;
			}
			set
			{
				this.returnsAcceptedField = value;
			}
		}
		public string tenderType
		{
			get
			{
				return this.tenderTypeField;
			}
			set
			{
				this.tenderTypeField = value;
			}
		}
		public string merchantVATRegistrationNumber
		{
			get
			{
				return this.merchantVATRegistrationNumberField;
			}
			set
			{
				this.merchantVATRegistrationNumberField = value;
			}
		}
		public string purchaserOrderDate
		{
			get
			{
				return this.purchaserOrderDateField;
			}
			set
			{
				this.purchaserOrderDateField = value;
			}
		}
		public string purchaserVATRegistrationNumber
		{
			get
			{
				return this.purchaserVATRegistrationNumberField;
			}
			set
			{
				this.purchaserVATRegistrationNumberField = value;
			}
		}
		public string vatInvoiceReferenceNumber
		{
			get
			{
				return this.vatInvoiceReferenceNumberField;
			}
			set
			{
				this.vatInvoiceReferenceNumberField = value;
			}
		}
		public string summaryCommodityCode
		{
			get
			{
				return this.summaryCommodityCodeField;
			}
			set
			{
				this.summaryCommodityCodeField = value;
			}
		}
		public string supplierOrderReference
		{
			get
			{
				return this.supplierOrderReferenceField;
			}
			set
			{
				this.supplierOrderReferenceField = value;
			}
		}
		public string userPO
		{
			get
			{
				return this.userPOField;
			}
			set
			{
				this.userPOField = value;
			}
		}
		public string costCenter
		{
			get
			{
				return this.costCenterField;
			}
			set
			{
				this.costCenterField = value;
			}
		}
		public string purchaserCode
		{
			get
			{
				return this.purchaserCodeField;
			}
			set
			{
				this.purchaserCodeField = value;
			}
		}
		public string taxable
		{
			get
			{
				return this.taxableField;
			}
			set
			{
				this.taxableField = value;
			}
		}
		public string amexDataTAA1
		{
			get
			{
				return this.amexDataTAA1Field;
			}
			set
			{
				this.amexDataTAA1Field = value;
			}
		}
		public string amexDataTAA2
		{
			get
			{
				return this.amexDataTAA2Field;
			}
			set
			{
				this.amexDataTAA2Field = value;
			}
		}
		public string amexDataTAA3
		{
			get
			{
				return this.amexDataTAA3Field;
			}
			set
			{
				this.amexDataTAA3Field = value;
			}
		}
		public string amexDataTAA4
		{
			get
			{
				return this.amexDataTAA4Field;
			}
			set
			{
				this.amexDataTAA4Field = value;
			}
		}
		public string invoiceDate
		{
			get
			{
				return this.invoiceDateField;
			}
			set
			{
				this.invoiceDateField = value;
			}
		}
	}
}
