using Microsoft.Web.Services3;
using System;
using System.Xml;
namespace CyberSource.Base
{
	internal class CybsClientInputFilter : SoapFilter
	{
		private const string REPLY_MESSAGE = "replyMessage";
		private const string NVP_REPLY = "nvpReply";
		private Logger logger;
		private CybsPolicy.RequestType requestType;
		private string nspace;
		private bool demo;
		public CybsClientInputFilter(CybsSecurityAssertion parentAssertion)
		{
			this.logger = parentAssertion.Logger;
			this.requestType = parentAssertion.RequestType;
			this.nspace = parentAssertion.NamespaceURI;
			this.demo = parentAssertion.Demo;
		}
		public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
		{
			if (this.logger != null && this.requestType == CybsPolicy.RequestType.SOAP)
			{
				XmlNodeList nodes = envelope.GetElementsByTagName("replyMessage", this.nspace);
				if (nodes != null && nodes.Count > 0)
				{
					this.logger.LogReply(nodes[0], this.demo);
				}
			}
			return SoapFilterResult.get_Continue();
		}
	}
}
