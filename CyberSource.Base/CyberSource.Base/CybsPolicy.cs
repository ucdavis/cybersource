using CyberSource.WSSecurity;
using Microsoft.Web.Services3.Design;
using System;
using System.Xml;
namespace CyberSource.Base
{
	public class CybsPolicy : Policy
	{
		public enum RequestType
		{
			NVP,
			SOAP
		}
		public static string SecurityLibraryVersion
		{
			get
			{
				return Signature.Version;
			}
		}
		public CybsPolicy(string keysDir, string keyFilename, string password, Logger logger, CybsPolicy.RequestType type, string nspace, bool demo) : base(new PolicyAssertion[]
		{
			new CybsSecurityAssertion(keysDir, keyFilename, password, logger, type, nspace, demo)
		})
		{
		}
		public static void SignDocument(XmlDocument doc, string keyFullPath, string password)
		{
			Signature.SignDocument(doc, keyFullPath, password);
		}
	}
}
