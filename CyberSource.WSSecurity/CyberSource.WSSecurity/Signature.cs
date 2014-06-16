using CybsWSSecurityIOP;
using System;
using System.Collections;
using System.Text;
using System.Xml;
namespace CyberSource.WSSecurity
{
	public class Signature
	{
		private const string DOTNET_WRAPPER_VERSION = "1.0.0";
		private static SignatureClass mSignature = new SignatureClass();
		public static string Version
		{
			get
			{
				return "1.0.0/" + Signature.mSignature.GetVersion();
			}
		}
		private Signature()
		{
		}
		public static void SignDocument(XmlDocument doc, string pkcs12Filename, string passphrase)
		{
			Encoding enc = Signature.GetEncoding(doc);
			byte[] docToSign = enc.GetBytes(doc.OuterXml);
			object temp;
			int ret = Signature.mSignature.SignDocument(docToSign, pkcs12Filename, passphrase, out temp);
			if (ret == 0)
			{
				XmlDocument signedDoc = new XmlDocument();
				signedDoc.PreserveWhitespace = true;
				signedDoc.LoadXml((string)temp);
				doc.RemoveAll();
				IEnumerator enumerator = signedDoc.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode node = (XmlNode)enumerator.Current;
						doc.AppendChild(doc.ImportNode(node, true));
					}
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			throw new SignException(ret, (string)Signature.mSignature.GetErrorMessage(ret));
		}
		private static Encoding GetEncoding(XmlDocument doc)
		{
			if (doc.HasChildNodes && doc.ChildNodes[0] is XmlDeclaration)
			{
				XmlDeclaration node = (XmlDeclaration)doc.ChildNodes[0];
				if (node.Encoding != string.Empty)
				{
					return Encoding.GetEncoding(node.Encoding);
				}
			}
			return Encoding.UTF8;
		}
	}
}
