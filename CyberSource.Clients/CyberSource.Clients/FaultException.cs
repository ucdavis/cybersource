using System;
using System.Xml;
namespace CyberSource.Clients
{
	public class FaultException : ApplicationException
	{
		private XmlDocument mFaultDocument;
		private XmlQualifiedName mCode;
		private string mMessage;
		private string mRequestID;
		public XmlDocument FaultDocument
		{
			get
			{
				return this.mFaultDocument;
			}
		}
		public XmlQualifiedName Code
		{
			get
			{
				return this.mCode;
			}
		}
		public override string Message
		{
			get
			{
				return this.mMessage;
			}
		}
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
				return this.mFaultDocument.OuterXml;
			}
		}
		internal FaultException(XmlDocument faultDocument, string nspace)
		{
			this.mFaultDocument = faultDocument;
			this.ExtractFields(nspace);
		}
		private void ExtractFields(string nspace)
		{
			if (this.mFaultDocument != null)
			{
				this.mMessage = this.GetTextValue("faultstring", string.Empty);
				this.mRequestID = this.GetTextValue("requestID", nspace);
				XmlNode faultCodeText = this.GetText("faultcode", string.Empty);
				string faultCode = faultCodeText.Value;
				char[] COLON = new char[]
				{
					':'
				};
				string[] parts = faultCode.Split(COLON, 2);
				if (parts.Length == 2)
				{
					string codeNameSpace = faultCodeText.GetNamespaceOfPrefix(parts[0]);
					this.mCode = new XmlQualifiedName(parts[1], codeNameSpace);
					return;
				}
				this.mCode = new XmlQualifiedName(faultCode);
			}
		}
		private string GetTextValue(string name, string nspace)
		{
			XmlText text = this.GetText(name, nspace);
			if (text != null)
			{
				return text.Value;
			}
			return null;
		}
		private XmlText GetText(string name, string nspace)
		{
			XmlNodeList nodes = this.mFaultDocument.GetElementsByTagName(name, nspace);
			if (nodes.Count > 0 && nodes[0].HasChildNodes)
			{
				return (XmlText)nodes[0].ChildNodes[0];
			}
			return null;
		}
	}
}
