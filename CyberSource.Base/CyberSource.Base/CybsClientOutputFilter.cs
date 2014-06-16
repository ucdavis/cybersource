using Microsoft.Web.Services3;
using System;
using System.IO;
using System.Xml;
namespace CyberSource.Base
{
	internal class CybsClientOutputFilter : SoapFilter
	{
		private const string REQUEST_MESSAGE = "requestMessage";
		private string keyFullPath;
		private string password;
		private Logger logger;
		private CybsPolicy.RequestType requestType;
		private string nspace;
		private bool demo;
		public CybsClientOutputFilter(CybsSecurityAssertion parentAssertion)
		{
			this.keyFullPath = Path.Combine(parentAssertion.KeysDir, parentAssertion.KeyFilename);
			this.password = parentAssertion.Password;
			this.logger = parentAssertion.Logger;
			this.requestType = parentAssertion.RequestType;
			this.nspace = parentAssertion.NamespaceURI;
			this.demo = parentAssertion.Demo;
		}
		public override SoapFilterResult ProcessMessage(SoapEnvelope envelope)
		{
			if (this.logger != null && this.requestType == CybsPolicy.RequestType.SOAP)
			{
				XmlNodeList nodes = envelope.GetElementsByTagName("requestMessage", this.nspace);
				if (nodes != null && nodes.Count > 0)
				{
					this.logger.LogRequest(nodes[0], this.demo);
				}
			}
			CybsPolicy.SignDocument(envelope, this.keyFullPath, this.password);
			return SoapFilterResult.get_Continue();
		}
	}
}
