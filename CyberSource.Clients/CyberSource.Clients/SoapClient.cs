using CyberSource.Base;
using CyberSource.Clients.SoapWebReference;
using CyberSource.WSSecurity;
using System;
using System.Web.Services.Protocols;
namespace CyberSource.Clients
{
	public class SoapClient : BaseClient
	{
		public static readonly string CYBS_NAMESPACE;
		static SoapClient()
		{
			SoapClient.CYBS_NAMESPACE = BaseClient.GetXmlElementAttributeNamespace(typeof(TransactionProcessorWse));
		}
		private SoapClient()
		{
		}
		public static ReplyMessage RunTransaction(RequestMessage requestMessage)
		{
			return SoapClient.RunTransaction(null, requestMessage);
		}
		public static ReplyMessage RunTransaction(Configuration config, RequestMessage requestMessage)
		{
			SoapClient.DetermineEffectiveMerchantID(ref config, requestMessage);
			SoapClient.SetVersionInformation(requestMessage);
			Logger logger = BaseClient.PrepareLog(config);
			BaseClient.SetConnectionLimit(config);
			TransactionProcessorWse proc = null;
			ReplyMessage result;
			try
			{
				proc = new TransactionProcessorWse(config.EffectiveServerURL);
				proc.Timeout = config.Timeout * 1000;
				if (BaseClient.mProxy != null)
				{
					proc.Proxy = BaseClient.mProxy;
				}
				proc.SetPolicy(new CybsPolicy(config.KeysDirectory, config.EffectiveKeyFilename, config.EffectivePassword, logger, CybsPolicy.RequestType.SOAP, SoapClient.CYBS_NAMESPACE, config.Demo));
				result = proc.runTransaction(requestMessage);
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
				SoapBodyException sbe = new SoapBodyException(se, SoapClient.CYBS_NAMESPACE);
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
		private static void DetermineEffectiveMerchantID(ref Configuration config, RequestMessage request)
		{
			string requestMerchantID = request.merchantID;
			if (config == null)
			{
				config = BaseClient.BuildConfigurationForRequest(requestMerchantID);
			}
			if (requestMerchantID == null)
			{
				request.merchantID = config.NonNullMerchantID;
			}
		}
		private static void SetVersionInformation(RequestMessage requestMessage)
		{
			requestMessage.clientLibrary = ".NET Soap";
			requestMessage.clientLibraryVersion = "5.0.2";
			requestMessage.clientEnvironment = BaseClient.mEnvironmentInfo;
			requestMessage.clientSecurityLibraryVersion = CybsPolicy.SecurityLibraryVersion;
		}
	}
}
