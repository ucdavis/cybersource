using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Design;
using System;
namespace CyberSource.Base
{
	internal class CybsSecurityAssertion : SecurityPolicyAssertion
	{
		private string keysDir;
		private string keyFilename;
		private string password;
		private Logger logger;
		private CybsPolicy.RequestType requestType;
		private string nspace;
		private bool demo;
		public string KeysDir
		{
			get
			{
				return this.keysDir;
			}
		}
		public string KeyFilename
		{
			get
			{
				return this.keyFilename;
			}
		}
		public string Password
		{
			get
			{
				return this.password;
			}
		}
		public Logger Logger
		{
			get
			{
				return this.logger;
			}
		}
		public CybsPolicy.RequestType RequestType
		{
			get
			{
				return this.requestType;
			}
		}
		public string NamespaceURI
		{
			get
			{
				return this.nspace;
			}
		}
		public bool Demo
		{
			get
			{
				return this.demo;
			}
		}
		public CybsSecurityAssertion(string keysDir, string keyFilename, string password, Logger logger, CybsPolicy.RequestType requestType, string nspace, bool demo)
		{
			this.keysDir = keysDir;
			this.keyFilename = keyFilename;
			this.password = password;
			this.logger = logger;
			this.requestType = requestType;
			this.nspace = nspace;
			this.demo = demo;
		}
		public override SoapFilter CreateClientOutputFilter(FilterCreationContext context)
		{
			return new CybsClientOutputFilter(this);
		}
		public override SoapFilter CreateClientInputFilter(FilterCreationContext context)
		{
			if (this.logger != null && this.requestType == CybsPolicy.RequestType.SOAP)
			{
				return new CybsClientInputFilter(this);
			}
			return null;
		}
		public override SoapFilter CreateServiceOutputFilter(FilterCreationContext context)
		{
			return null;
		}
		public override SoapFilter CreateServiceInputFilter(FilterCreationContext context)
		{
			return null;
		}
	}
}
