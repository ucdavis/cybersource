using System;
using System.Web.Services.Protocols;
using System.Xml;
namespace CyberSource.Clients
{
	public class SoapBodyException : SoapException
	{
		private string mRequestID;
		public string RequestID
		{
			get
			{
				return this.mRequestID;
			}
		}
		public string LogString
		{
			get
			{
				return string.Concat(new object[]
				{
					base.Code,
					Environment.NewLine,
					this.Message,
					Environment.NewLine,
					"RequestID: ",
					(this.mRequestID != null) ? this.mRequestID : "<null>",
					Environment.NewLine,
					"Detail: ",
					(base.Detail != null) ? base.Detail.OuterXml : "<null>"
				});
			}
		}
		internal SoapBodyException(SoapException se, string nspace) : base(se.Message, se.Code, se.Actor, se.Detail, se.InnerException)
		{
			this.GetRequestID(nspace);
		}
		private void GetRequestID(string nspace)
		{
			if (base.Detail != null)
			{
				XmlDocument doc = new XmlDocument();
				doc.AppendChild(doc.ImportNode(base.Detail, true));
				XmlNodeList nodes = doc.GetElementsByTagName("requestID", nspace);
				if (nodes.Count > 0 && nodes[0].HasChildNodes)
				{
					this.mRequestID = nodes[0].ChildNodes[0].Value;
				}
			}
		}
	}
}
