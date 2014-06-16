using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class Item
	{
		private string unitPriceField;
		private string quantityField;
		private string productCodeField;
		private string productNameField;
		private string productSKUField;
		private string productRiskField;
		private string taxAmountField;
		private string cityOverrideAmountField;
		private string cityOverrideRateField;
		private string countyOverrideAmountField;
		private string countyOverrideRateField;
		private string districtOverrideAmountField;
		private string districtOverrideRateField;
		private string stateOverrideAmountField;
		private string stateOverrideRateField;
		private string countryOverrideAmountField;
		private string countryOverrideRateField;
		private string orderAcceptanceCityField;
		private string orderAcceptanceCountyField;
		private string orderAcceptanceCountryField;
		private string orderAcceptanceStateField;
		private string orderAcceptancePostalCodeField;
		private string orderOriginCityField;
		private string orderOriginCountyField;
		private string orderOriginCountryField;
		private string orderOriginStateField;
		private string orderOriginPostalCodeField;
		private string shipFromCityField;
		private string shipFromCountyField;
		private string shipFromCountryField;
		private string shipFromStateField;
		private string shipFromPostalCodeField;
		private string exportField;
		private string noExportField;
		private string nationalTaxField;
		private string vatRateField;
		private string sellerRegistrationField;
		private string buyerRegistrationField;
		private string middlemanRegistrationField;
		private string pointOfTitleTransferField;
		private string giftCategoryField;
		private string timeCategoryField;
		private string hostHedgeField;
		private string timeHedgeField;
		private string velocityHedgeField;
		private string nonsensicalHedgeField;
		private string phoneHedgeField;
		private string unitOfMeasureField;
		private string taxRateField;
		private string totalAmountField;
		private string discountAmountField;
		private string discountRateField;
		private string commodityCodeField;
		private string grossNetIndicatorField;
		private string taxTypeAppliedField;
		private string discountIndicatorField;
		private string alternateTaxIDField;
		private string alternateTaxAmountField;
		private string alternateTaxTypeAppliedField;
		private string alternateTaxRateField;
		private string alternateTaxTypeField;
		private string localTaxField;
		private string zeroCostToCustomerIndicatorField;
		private string idField;
		public string unitPrice
		{
			get
			{
				return this.unitPriceField;
			}
			set
			{
				this.unitPriceField = value;
			}
		}
		[XmlElement(DataType = "integer")]
		public string quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}
		public string productCode
		{
			get
			{
				return this.productCodeField;
			}
			set
			{
				this.productCodeField = value;
			}
		}
		public string productName
		{
			get
			{
				return this.productNameField;
			}
			set
			{
				this.productNameField = value;
			}
		}
		public string productSKU
		{
			get
			{
				return this.productSKUField;
			}
			set
			{
				this.productSKUField = value;
			}
		}
		public string productRisk
		{
			get
			{
				return this.productRiskField;
			}
			set
			{
				this.productRiskField = value;
			}
		}
		public string taxAmount
		{
			get
			{
				return this.taxAmountField;
			}
			set
			{
				this.taxAmountField = value;
			}
		}
		public string cityOverrideAmount
		{
			get
			{
				return this.cityOverrideAmountField;
			}
			set
			{
				this.cityOverrideAmountField = value;
			}
		}
		public string cityOverrideRate
		{
			get
			{
				return this.cityOverrideRateField;
			}
			set
			{
				this.cityOverrideRateField = value;
			}
		}
		public string countyOverrideAmount
		{
			get
			{
				return this.countyOverrideAmountField;
			}
			set
			{
				this.countyOverrideAmountField = value;
			}
		}
		public string countyOverrideRate
		{
			get
			{
				return this.countyOverrideRateField;
			}
			set
			{
				this.countyOverrideRateField = value;
			}
		}
		public string districtOverrideAmount
		{
			get
			{
				return this.districtOverrideAmountField;
			}
			set
			{
				this.districtOverrideAmountField = value;
			}
		}
		public string districtOverrideRate
		{
			get
			{
				return this.districtOverrideRateField;
			}
			set
			{
				this.districtOverrideRateField = value;
			}
		}
		public string stateOverrideAmount
		{
			get
			{
				return this.stateOverrideAmountField;
			}
			set
			{
				this.stateOverrideAmountField = value;
			}
		}
		public string stateOverrideRate
		{
			get
			{
				return this.stateOverrideRateField;
			}
			set
			{
				this.stateOverrideRateField = value;
			}
		}
		public string countryOverrideAmount
		{
			get
			{
				return this.countryOverrideAmountField;
			}
			set
			{
				this.countryOverrideAmountField = value;
			}
		}
		public string countryOverrideRate
		{
			get
			{
				return this.countryOverrideRateField;
			}
			set
			{
				this.countryOverrideRateField = value;
			}
		}
		public string orderAcceptanceCity
		{
			get
			{
				return this.orderAcceptanceCityField;
			}
			set
			{
				this.orderAcceptanceCityField = value;
			}
		}
		public string orderAcceptanceCounty
		{
			get
			{
				return this.orderAcceptanceCountyField;
			}
			set
			{
				this.orderAcceptanceCountyField = value;
			}
		}
		public string orderAcceptanceCountry
		{
			get
			{
				return this.orderAcceptanceCountryField;
			}
			set
			{
				this.orderAcceptanceCountryField = value;
			}
		}
		public string orderAcceptanceState
		{
			get
			{
				return this.orderAcceptanceStateField;
			}
			set
			{
				this.orderAcceptanceStateField = value;
			}
		}
		public string orderAcceptancePostalCode
		{
			get
			{
				return this.orderAcceptancePostalCodeField;
			}
			set
			{
				this.orderAcceptancePostalCodeField = value;
			}
		}
		public string orderOriginCity
		{
			get
			{
				return this.orderOriginCityField;
			}
			set
			{
				this.orderOriginCityField = value;
			}
		}
		public string orderOriginCounty
		{
			get
			{
				return this.orderOriginCountyField;
			}
			set
			{
				this.orderOriginCountyField = value;
			}
		}
		public string orderOriginCountry
		{
			get
			{
				return this.orderOriginCountryField;
			}
			set
			{
				this.orderOriginCountryField = value;
			}
		}
		public string orderOriginState
		{
			get
			{
				return this.orderOriginStateField;
			}
			set
			{
				this.orderOriginStateField = value;
			}
		}
		public string orderOriginPostalCode
		{
			get
			{
				return this.orderOriginPostalCodeField;
			}
			set
			{
				this.orderOriginPostalCodeField = value;
			}
		}
		public string shipFromCity
		{
			get
			{
				return this.shipFromCityField;
			}
			set
			{
				this.shipFromCityField = value;
			}
		}
		public string shipFromCounty
		{
			get
			{
				return this.shipFromCountyField;
			}
			set
			{
				this.shipFromCountyField = value;
			}
		}
		public string shipFromCountry
		{
			get
			{
				return this.shipFromCountryField;
			}
			set
			{
				this.shipFromCountryField = value;
			}
		}
		public string shipFromState
		{
			get
			{
				return this.shipFromStateField;
			}
			set
			{
				this.shipFromStateField = value;
			}
		}
		public string shipFromPostalCode
		{
			get
			{
				return this.shipFromPostalCodeField;
			}
			set
			{
				this.shipFromPostalCodeField = value;
			}
		}
		public string export
		{
			get
			{
				return this.exportField;
			}
			set
			{
				this.exportField = value;
			}
		}
		public string noExport
		{
			get
			{
				return this.noExportField;
			}
			set
			{
				this.noExportField = value;
			}
		}
		public string nationalTax
		{
			get
			{
				return this.nationalTaxField;
			}
			set
			{
				this.nationalTaxField = value;
			}
		}
		public string vatRate
		{
			get
			{
				return this.vatRateField;
			}
			set
			{
				this.vatRateField = value;
			}
		}
		public string sellerRegistration
		{
			get
			{
				return this.sellerRegistrationField;
			}
			set
			{
				this.sellerRegistrationField = value;
			}
		}
		public string buyerRegistration
		{
			get
			{
				return this.buyerRegistrationField;
			}
			set
			{
				this.buyerRegistrationField = value;
			}
		}
		public string middlemanRegistration
		{
			get
			{
				return this.middlemanRegistrationField;
			}
			set
			{
				this.middlemanRegistrationField = value;
			}
		}
		public string pointOfTitleTransfer
		{
			get
			{
				return this.pointOfTitleTransferField;
			}
			set
			{
				this.pointOfTitleTransferField = value;
			}
		}
		public string giftCategory
		{
			get
			{
				return this.giftCategoryField;
			}
			set
			{
				this.giftCategoryField = value;
			}
		}
		public string timeCategory
		{
			get
			{
				return this.timeCategoryField;
			}
			set
			{
				this.timeCategoryField = value;
			}
		}
		public string hostHedge
		{
			get
			{
				return this.hostHedgeField;
			}
			set
			{
				this.hostHedgeField = value;
			}
		}
		public string timeHedge
		{
			get
			{
				return this.timeHedgeField;
			}
			set
			{
				this.timeHedgeField = value;
			}
		}
		public string velocityHedge
		{
			get
			{
				return this.velocityHedgeField;
			}
			set
			{
				this.velocityHedgeField = value;
			}
		}
		public string nonsensicalHedge
		{
			get
			{
				return this.nonsensicalHedgeField;
			}
			set
			{
				this.nonsensicalHedgeField = value;
			}
		}
		public string phoneHedge
		{
			get
			{
				return this.phoneHedgeField;
			}
			set
			{
				this.phoneHedgeField = value;
			}
		}
		public string unitOfMeasure
		{
			get
			{
				return this.unitOfMeasureField;
			}
			set
			{
				this.unitOfMeasureField = value;
			}
		}
		public string taxRate
		{
			get
			{
				return this.taxRateField;
			}
			set
			{
				this.taxRateField = value;
			}
		}
		public string totalAmount
		{
			get
			{
				return this.totalAmountField;
			}
			set
			{
				this.totalAmountField = value;
			}
		}
		public string discountAmount
		{
			get
			{
				return this.discountAmountField;
			}
			set
			{
				this.discountAmountField = value;
			}
		}
		public string discountRate
		{
			get
			{
				return this.discountRateField;
			}
			set
			{
				this.discountRateField = value;
			}
		}
		public string commodityCode
		{
			get
			{
				return this.commodityCodeField;
			}
			set
			{
				this.commodityCodeField = value;
			}
		}
		public string grossNetIndicator
		{
			get
			{
				return this.grossNetIndicatorField;
			}
			set
			{
				this.grossNetIndicatorField = value;
			}
		}
		public string taxTypeApplied
		{
			get
			{
				return this.taxTypeAppliedField;
			}
			set
			{
				this.taxTypeAppliedField = value;
			}
		}
		public string discountIndicator
		{
			get
			{
				return this.discountIndicatorField;
			}
			set
			{
				this.discountIndicatorField = value;
			}
		}
		public string alternateTaxID
		{
			get
			{
				return this.alternateTaxIDField;
			}
			set
			{
				this.alternateTaxIDField = value;
			}
		}
		public string alternateTaxAmount
		{
			get
			{
				return this.alternateTaxAmountField;
			}
			set
			{
				this.alternateTaxAmountField = value;
			}
		}
		public string alternateTaxTypeApplied
		{
			get
			{
				return this.alternateTaxTypeAppliedField;
			}
			set
			{
				this.alternateTaxTypeAppliedField = value;
			}
		}
		public string alternateTaxRate
		{
			get
			{
				return this.alternateTaxRateField;
			}
			set
			{
				this.alternateTaxRateField = value;
			}
		}
		public string alternateTaxType
		{
			get
			{
				return this.alternateTaxTypeField;
			}
			set
			{
				this.alternateTaxTypeField = value;
			}
		}
		public string localTax
		{
			get
			{
				return this.localTaxField;
			}
			set
			{
				this.localTaxField = value;
			}
		}
		public string zeroCostToCustomerIndicator
		{
			get
			{
				return this.zeroCostToCustomerIndicatorField;
			}
			set
			{
				this.zeroCostToCustomerIndicatorField = value;
			}
		}
		[XmlAttribute(DataType = "integer")]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
	}
}
