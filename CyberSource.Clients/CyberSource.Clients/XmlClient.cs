using CyberSource.Base;
using CyberSource.WSSecurity;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
namespace CyberSource.Clients
{
	public class XmlClient : BaseClient
	{
		private const string SOAP_ENVELOPE = "<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body></soap:Body></soap:Envelope>";
		private const string REQUEST_MESSAGE = "requestMessage";
		private const string REPLY_MESSAGE = "replyMessage";
		private const string MERCHANT_REFERENCE_CODE = "merchantReferenceCode";
		private static XmlDocument mSoapEnvelope;
		static XmlClient()
		{
			XmlClient.mSoapEnvelope = new XmlDocument();
			XmlClient.mSoapEnvelope.LoadXml("<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body></soap:Body></soap:Envelope>");
		}
		private XmlClient()
		{
		}
		public static XmlDocument RunTransaction(XmlDocument request)
		{
			return XmlClient.RunTransaction(null, request);
		}
		public static XmlDocument RunTransaction(Configuration config, XmlDocument request)
		{
			string nspace = XmlClient.GetRequestNamespace(request);
			if (nspace == null)
			{
				throw new ApplicationException("requestMessage is missing in the XML document.");
			}
			XmlClient.DetermineEffectiveMerchantID(ref config, request, nspace);
			XmlClient.SetVersionInformation(request, nspace);
			Logger logger = BaseClient.PrepareLog(config);
			BaseClient.SetConnectionLimit(config);
			if (logger != null)
			{
				logger.LogRequest(request, config.Demo);
			}
			XmlDocument doc = XmlClient.SoapWrap(request, nspace);
			string keyFullPath = Path.Combine(config.KeysDirectory, config.EffectiveKeyFilename);
			try
			{
				CybsPolicy.SignDocument(doc, keyFullPath, config.EffectivePassword);
			}
			catch (CyberSource.WSSecurity.SignException se3)
			{
				SignException se2 = new SignException(se3);
				if (logger != null)
				{
					logger.LogException(se2.LogString);
				}
				throw se2;
			}
			Encoding enc = XmlClient.GetEncoding(doc);
			byte[] requestBytes = enc.GetBytes(doc.OuterXml);
			XmlDocument result;
			try
			{
				HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(config.EffectiveServerURL);
				httpRequest.Method = "POST";
				httpRequest.ContentLength = (long)requestBytes.Length;
				httpRequest.UserAgent = ".NET XML";
				httpRequest.Timeout = config.Timeout * 1000;
				if (BaseClient.mProxy != null)
				{
					httpRequest.Proxy = BaseClient.mProxy;
				}
				Stream stream = httpRequest.GetRequestStream();
				stream.Write(requestBytes, 0, requestBytes.Length);
				stream.Close();
				WebResponse webResponse = httpRequest.GetResponse();
				XmlDocument reply = XmlClient.ReadXml(webResponse);
				XmlDocument unwrapped = XmlClient.SoapUnwrap(reply, nspace);
				if (logger != null)
				{
					logger.LogReply(unwrapped, config.Demo);
				}
				result = unwrapped;
			}
			catch (WebException we)
			{
				if (we.Status == WebExceptionStatus.ProtocolError && we.Response != null)
				{
					HttpWebResponse response = (HttpWebResponse)we.Response;
					if (response.StatusCode == HttpStatusCode.InternalServerError && response.ContentLength > 0L)
					{
						try
						{
							FaultException fe = new FaultException(XmlClient.ReadXml(response), nspace);
							if (logger != null)
							{
								logger.LogFault(fe.LogString);
							}
							throw fe;
						}
						catch (XmlException)
						{
							if (logger != null)
							{
								logger.LogException(we);
							}
							throw we;
						}
					}
				}
				if (logger != null)
				{
					logger.LogException(we);
				}
				throw we;
			}
			catch (Exception e)
			{
				if (logger != null)
				{
					logger.LogException(e);
				}
				throw e;
			}
			return result;
		}
		public static string GetRequestNamespace(XmlDocument request)
		{
			if (request == null)
			{
				return null;
			}
			XmlNodeList list = request.ChildNodes;
			foreach (XmlNode node in list)
			{
				if ("requestMessage".Equals(node.LocalName))
				{
					return node.NamespaceURI;
				}
			}
			return null;
		}
		private static void DetermineEffectiveMerchantID(ref Configuration config, XmlDocument request, string nspace)
		{
			string requestMerchantID = XmlClient.GetMerchantID(request, nspace);
			if (config == null)
			{
				config = BaseClient.BuildConfigurationForRequest(requestMerchantID);
			}
			if (requestMerchantID == null)
			{
				XmlClient.SetMerchantID(request, config.NonNullMerchantID, nspace);
			}
		}
		private static string GetMerchantID(XmlDocument request, string nspace)
		{
			string merchantID = null;
			XmlNode merchantIDNode = XmlClient.GetNode(request, "merchantID", nspace);
			if (merchantIDNode != null && merchantIDNode.ChildNodes != null && merchantIDNode.ChildNodes.Count > 0)
			{
				merchantID = merchantIDNode.ChildNodes[0].Value;
			}
			return merchantID;
		}
		private static void SetMerchantID(XmlDocument request, string merchantID, string nspace)
		{
			XmlNode requestMessageNode = XmlClient.GetNode(request, "requestMessage", nspace);
			if (requestMessageNode == null)
			{
				throw new ApplicationException("INVALID XML REQUEST:  requestMessage is missing!");
			}
			XmlNode previousSibling = null;
			XmlClient.SetField(requestMessageNode, ref previousSibling, "merchantID", merchantID, nspace);
		}
		private static XmlDocument ReadXml(WebResponse webResponse)
		{
			Stream stream = null;
			XmlDocument result;
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.PreserveWhitespace = true;
				stream = webResponse.GetResponseStream();
				xmlDoc.Load(stream);
				result = xmlDoc;
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			return result;
		}
		private static void SetVersionInformation(XmlDocument request, string nspace)
		{
			XmlNode requestMessageNode = XmlClient.GetNode(request, "requestMessage", nspace);
			XmlNode previousSibling = XmlClient.GetNode(request, "merchantReferenceCode", nspace);
			if (previousSibling == null)
			{
				previousSibling = XmlClient.GetNode(request, "merchantID", nspace);
			}
			XmlClient.SetField(requestMessageNode, ref previousSibling, "clientLibrary", ".NET XML", nspace);
			XmlClient.SetField(requestMessageNode, ref previousSibling, "clientLibraryVersion", "5.0.2", nspace);
			XmlClient.SetField(requestMessageNode, ref previousSibling, "clientEnvironment", BaseClient.mEnvironmentInfo, nspace);
			XmlClient.SetField(requestMessageNode, ref previousSibling, "clientSecurityLibraryVersion", CybsPolicy.SecurityLibraryVersion, nspace);
		}
		private static void SetField(XmlNode parentNode, ref XmlNode previousSibling, string tagName, string tagValue, string nspace)
		{
			XmlDocument doc = parentNode.OwnerDocument;
			XmlText text = doc.CreateTextNode(tagValue);
			XmlNode node = XmlClient.GetNode(doc, tagName, nspace);
			if (node == null)
			{
				node = doc.CreateElement(tagName, nspace);
				node.AppendChild(text);
				if (previousSibling != null)
				{
					parentNode.InsertAfter(node, previousSibling);
				}
				else
				{
					parentNode.PrependChild(node);
				}
			}
			else
			{
				if (node.HasChildNodes)
				{
					node.ReplaceChild(text, node.ChildNodes[0]);
				}
				else
				{
					node.AppendChild(text);
				}
			}
			previousSibling = node;
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
		private static XmlDocument SoapWrap(XmlDocument doc, string nspace)
		{
			XmlNode xmlDeclaration = XmlClient.GetXmlDeclarationNode(doc);
			XmlNode requestMessage = XmlClient.GetNode(doc, "requestMessage", nspace);
			XmlDocument wrapped = new XmlDocument();
			if (xmlDeclaration != null)
			{
				wrapped.AppendChild(wrapped.ImportNode(xmlDeclaration, true));
			}
			wrapped.AppendChild(wrapped.ImportNode(XmlClient.mSoapEnvelope.FirstChild, true));
			if (requestMessage != null)
			{
				wrapped.LastChild.FirstChild.AppendChild(wrapped.ImportNode(requestMessage, true));
			}
			return wrapped;
		}
		private static XmlDocument SoapUnwrap(XmlDocument doc, string nspace)
		{
			XmlNode xmlDeclaration = XmlClient.GetXmlDeclarationNode(doc);
			XmlNode replyMessage = XmlClient.GetNode(doc, "replyMessage", nspace);
			XmlDocument unwrapped = new XmlDocument();
			if (xmlDeclaration != null)
			{
				unwrapped.AppendChild(unwrapped.ImportNode(xmlDeclaration, true));
			}
			if (replyMessage != null)
			{
				unwrapped.AppendChild(unwrapped.ImportNode(replyMessage, true));
			}
			return unwrapped;
		}
		private static XmlNode GetXmlDeclarationNode(XmlDocument doc)
		{
			if (doc.HasChildNodes && doc.ChildNodes[0] is XmlDeclaration)
			{
				return doc.ChildNodes[0];
			}
			return null;
		}
		private static XmlNode GetNode(XmlDocument doc, string tagName, string nspace)
		{
			XmlNodeList nodes = doc.GetElementsByTagName(tagName, nspace);
			if (nodes != null && nodes.Count > 0)
			{
				return nodes[0];
			}
			return null;
		}
	}
}
