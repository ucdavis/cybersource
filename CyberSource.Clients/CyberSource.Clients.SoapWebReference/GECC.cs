using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Xml", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
	[Serializable]
	public class GECC
	{
		private string saleTypeField;
		private string planNumberField;
		private string sequenceNumberField;
		private string promotionEndDateField;
		private string promotionPlanField;
		private string[] lineField;
		public string saleType
		{
			get
			{
				return this.saleTypeField;
			}
			set
			{
				this.saleTypeField = value;
			}
		}
		public string planNumber
		{
			get
			{
				return this.planNumberField;
			}
			set
			{
				this.planNumberField = value;
			}
		}
		public string sequenceNumber
		{
			get
			{
				return this.sequenceNumberField;
			}
			set
			{
				this.sequenceNumberField = value;
			}
		}
		public string promotionEndDate
		{
			get
			{
				return this.promotionEndDateField;
			}
			set
			{
				this.promotionEndDateField = value;
			}
		}
		public string promotionPlan
		{
			get
			{
				return this.promotionPlanField;
			}
			set
			{
				this.promotionPlanField = value;
			}
		}
		[XmlElement("line")]
		public string[] line
		{
			get
			{
				return this.lineField;
			}
			set
			{
				this.lineField = value;
			}
		}
	}
}
