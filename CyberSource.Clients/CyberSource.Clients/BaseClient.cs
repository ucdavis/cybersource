using CyberSource.Base;
using System;
using System.Net;
using System.Reflection;
using System.Xml.Serialization;
namespace CyberSource.Clients
{
	public abstract class BaseClient
	{
		public const string CLIENT_LIBRARY_VERSION = "5.0.2";
		protected const string MERCHANT_ID = "merchantID";
		private const string PROXY_URL = "proxyURL";
		private const string PROXY_USER = "proxyUser";
		private const string PROXY_PASSWORD = "proxyPassword";
		private const string BASIC_AUTH = "Basic";
		protected static WebProxy mProxy;
		protected static string mEnvironmentInfo;
		static BaseClient()
		{
			BaseClient.mProxy = null;
			BaseClient.mEnvironmentInfo = string.Concat(new object[]
			{
				Environment.OSVersion.Platform,
				Environment.OSVersion.Version.ToString(),
				"-CLR",
				Environment.Version.ToString()
			});
			BaseClient.SetupProxy();
		}
		private static void SetupProxy()
		{
			string proxyURL = AppSettings.GetSetting(null, "proxyURL");
			if (proxyURL != null)
			{
				BaseClient.mProxy = new WebProxy(proxyURL);
				string proxyUser = AppSettings.GetSetting(null, "proxyUser");
				if (proxyUser != null)
				{
					string proxyPassword = AppSettings.GetSetting(null, "proxyPassword");
					NetworkCredential credential = new NetworkCredential(proxyUser, proxyPassword);
					CredentialCache cache = new CredentialCache();
					cache.Add(new Uri(proxyURL), "Basic", credential);
					BaseClient.mProxy.Credentials = cache;
				}
			}
		}
		public static Configuration BuildConfiguration(string merchantID)
		{
			return BaseClient.InternalBuildConfiguration(merchantID, false);
		}
		protected static Configuration BuildConfigurationForRequest(string requestMerchantID)
		{
			return BaseClient.InternalBuildConfiguration(requestMerchantID, true);
		}
		private static Configuration InternalBuildConfiguration(string merchantID, bool failIfNoMerchantID)
		{
			Configuration config = new Configuration();
			if (merchantID == null)
			{
				merchantID = AppSettings.GetSetting(null, "merchantID");
			}
			if (merchantID != null || failIfNoMerchantID)
			{
				config.MerchantID = merchantID;
			}
			string keysDirectory = AppSettings.GetSetting(merchantID, "keysDirectory");
			if (keysDirectory != null)
			{
				config.KeysDirectory = keysDirectory;
			}
			else
			{
				config.KeysDirectory = AppSettings.GetSetting(merchantID, "keysDir");
			}
			int boolVal = AppSettings.GetBoolSetting(merchantID, "sendToProduction");
			if (boolVal != -1)
			{
				config.SendToProduction = (boolVal == 1);
			}
			boolVal = AppSettings.GetBoolSetting(merchantID, "enableLog");
			config.setLogProperties(boolVal == 1, AppSettings.GetSetting(merchantID, "logDirectory"));
			config.ServerURL = AppSettings.GetSetting(merchantID, "serverURL");
			if (config.ServerURL == null)
			{
				config.ServerURL = AppSettings.GetSetting(merchantID, "cybersourceURL");
			}
			config.KeyFilename = AppSettings.GetSetting(merchantID, "keyFilename");
			config.Password = AppSettings.GetSetting(merchantID, "password");
			config.LogFilename = AppSettings.GetSetting(merchantID, "logFilename");
			config.LogMaximumSize = AppSettings.GetIntSetting(merchantID, "logMaximumSize");
			config.Timeout = AppSettings.GetIntSetting(merchantID, "timeout");
			boolVal = AppSettings.GetBoolSetting(merchantID, "demo");
			if (boolVal != -1)
			{
				config.Demo = (boolVal == 1);
			}
			config.ConnectionLimit = AppSettings.GetIntSetting(merchantID, "connectionLimit");
			return config;
		}
		protected static Logger PrepareLog(Configuration config)
		{
			Logger logger = null;
			if (config.EnableLog)
			{
				logger = Logger.GetInstance(config.LogDirectory, config.LogFilename, config.LogMaximumSize);
				if (logger != null)
				{
					logger.LogTransactionStart(config.LogString);
				}
			}
			return logger;
		}
		protected static string GetXmlElementAttributeNamespace(Type type)
		{
			MethodInfo mInfo = type.GetMethod("runTransaction");
			ICustomAttributeProvider prov = mInfo.ReturnTypeCustomAttributes;
			object[] attribs = prov.GetCustomAttributes(false);
			Type xeaType = typeof(XmlElementAttribute);
			object[] array = attribs;
			for (int i = 0; i < array.Length; i++)
			{
				object attrib = array[i];
				if (attrib.GetType() == xeaType)
				{
					return ((XmlElementAttribute)attrib).Namespace;
				}
			}
			throw new ApplicationException("The namespace could not be determined from the generated proxy class.  Please update the web reference.  If you get this exception again, please contact CyberSource.");
		}
		protected static void SetConnectionLimit(Configuration config)
		{
			if (config.ConnectionLimit != -1)
			{
				Uri uri = new Uri(config.EffectiveServerURL);
				ServicePoint sp = ServicePointManager.FindServicePoint(uri);
				sp.ConnectionLimit = config.ConnectionLimit;
			}
		}
	}
}
