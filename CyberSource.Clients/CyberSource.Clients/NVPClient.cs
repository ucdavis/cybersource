using CyberSource.Base;
using CyberSource.Clients.NVPWebReference;
using CyberSource.WSSecurity;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Web.Services.Protocols;
namespace CyberSource.Clients
{
	public class NVPClient : BaseClient
	{
		public static readonly string CYBS_NAMESPACE;
		static NVPClient()
		{
			NVPClient.CYBS_NAMESPACE = BaseClient.GetXmlElementAttributeNamespace(typeof(NVPTransactionProcessorWse));
		}
		private NVPClient()
		{
		}
		public static Hashtable RunTransaction(Hashtable request)
		{
			return NVPClient.RunTransaction(null, request);
		}
		public static Hashtable RunTransaction(Configuration config, Hashtable request)
		{
			NVPClient.DetermineEffectiveMerchantID(ref config, request);
			NVPClient.SetVersionInformation(request);
			Logger logger = BaseClient.PrepareLog(config);
			BaseClient.SetConnectionLimit(config);
			NVPTransactionProcessorWse proc = null;
			Hashtable result;
			try
			{
				proc = new NVPTransactionProcessorWse(config.EffectiveServerURL);
				proc.Timeout = config.Timeout * 1000;
				if (BaseClient.mProxy != null)
				{
					proc.Proxy = BaseClient.mProxy;
				}
				proc.SetPolicy(new CybsPolicy(config.KeysDirectory, config.EffectiveKeyFilename, config.EffectivePassword, logger, CybsPolicy.RequestType.NVP, NVPClient.CYBS_NAMESPACE, config.Demo));
				if (logger != null)
				{
					logger.LogRequest(request, config.Demo);
				}
				Hashtable reply = NVPClient.String2Hash(proc.runTransaction(NVPClient.Hash2String(request)));
				if (logger != null)
				{
					logger.LogReply(reply, config.Demo);
				}
				result = reply;
			}
			catch (SoapHeaderException she)
			{
				if (logger != null)
				{
					logger.LogSoapException(she);
				}
				throw she;
			}
			catch (SoapException se)
			{
				SoapBodyException sbe = new SoapBodyException(se, NVPClient.CYBS_NAMESPACE);
				if (logger != null)
				{
					logger.LogFault(sbe.LogString);
				}
				throw sbe;
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
			catch (Exception e)
			{
				if (logger != null)
				{
					logger.LogException(e);
				}
				throw e;
			}
			finally
			{
				if (proc != null)
				{
					proc.Dispose();
				}
			}
			return result;
		}
		private static void DetermineEffectiveMerchantID(ref Configuration config, Hashtable request)
		{
			string requestMerchantID = (string)request["merchantID"];
			if (config == null)
			{
				config = BaseClient.BuildConfigurationForRequest(requestMerchantID);
			}
			if (requestMerchantID == null)
			{
				request["merchantID"] = config.NonNullMerchantID;
			}
		}
		private static string Hash2String(Hashtable src)
		{
			StringBuilder dest = new StringBuilder();
			foreach (string key in src.Keys)
			{
				dest.AppendFormat("{0}={1}\n", key, src[key]);
			}
			return dest.ToString();
		}
		private static Hashtable String2Hash(string src)
		{
			char[] EQUAL_SIGN = new char[]
			{
				'='
			};
			Hashtable dest = new Hashtable();
			StringReader reader = new StringReader(src);
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				string[] parts = line.Split(EQUAL_SIGN, 2);
				if (parts.Length > 0)
				{
					dest.Add(parts[0], (parts.Length == 2) ? parts[1] : null);
				}
			}
			return dest;
		}
		private static void SetVersionInformation(Hashtable request)
		{
			request["clientLibrary"] = ".NET NVP";
			request["clientLibraryVersion"] = "5.0.2";
			request["clientEnvironment"] = BaseClient.mEnvironmentInfo;
			request["clientSecurityLibraryVersion"] = CybsPolicy.SecurityLibraryVersion;
		}
	}
}
