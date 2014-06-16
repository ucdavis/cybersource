using System;
namespace CyberSource.Clients
{
	public class Configuration
	{
		internal const string MERCHANT_ID = "merchantID";
		internal const string KEYS_DIRECTORY = "keysDirectory";
		internal const string KEYS_DIR = "keysDir";
		internal const string SEND_TO_PRODUCTION = "sendToProduction";
		internal const string ENABLE_LOG = "enableLog";
		internal const string LOG_DIRECTORY = "logDirectory";
		internal const string SERVER_URL = "serverURL";
		internal const string CYBERSOURCE_URL = "cybersourceURL";
		internal const string KEY_FILENAME = "keyFilename";
		internal const string PASSWORD = "password";
		internal const string LOG_FILENAME = "logFilename";
		internal const string LOG_MAXIMUM_SIZE = "logMaximumSize";
		internal const string TIMEOUT = "timeout";
		internal const string DEMO = "demo";
		internal const string CONNECTION_LIMIT = "connectionLimit";
		public const string DEFAULT_LOG_FILENAME = "cybs.log";
		public const int DEFAULT_LOG_MAXIMUM_SIZE = 10;
		public const int DEFAULT_TIMEOUT = 130;
		private const string TEST_URL = "https://ics2wstest.ic3.com/commerce/1.x/transactionProcessor";
		private const string PROD_URL = "https://ics2ws.ic3.com/commerce/1.x/transactionProcessor";
		private const string PROD_HOST = "ics2ws.ic3.com";
		private const string P12_EXTENSION = ".p12";
		private const string NV_SEPARATOR = "=";
		private const string NVP_SEPARATOR = ",";
		private string merchantID;
		private string keysDirectory;
		private bool sendToProduction;
		private bool enableLog;
		private string logDirectory;
		private string serverURL;
		private string keyFilename;
		private string password;
		private string logFilename;
		private int logMaximumSize = -1;
		private int timeout = -1;
		private bool demo;
		private int connectionLimit = -1;
		private bool isSendToProductionSet;
		public string MerchantID
		{
			get
			{
				return this.merchantID;
			}
			set
			{
				this.merchantID = value;
				this.CheckMerchantID();
			}
		}
		public string KeysDirectory
		{
			get
			{
				return this.keysDirectory;
			}
			set
			{
				this.keysDirectory = value;
				if (this.keysDirectory == null)
				{
					throw new ApplicationException("CONFIGURATION BUG:  keysDirectory is missing!");
				}
			}
		}
		public bool SendToProduction
		{
			get
			{
				return this.sendToProduction;
			}
			set
			{
				this.sendToProduction = value;
				this.isSendToProductionSet = true;
			}
		}
		public bool EnableLog
		{
			get
			{
				return this.enableLog;
			}
		}
		public string LogDirectory
		{
			get
			{
				return this.logDirectory;
			}
		}
		public string ServerURL
		{
			get
			{
				return this.serverURL;
			}
			set
			{
				this.serverURL = value;
			}
		}
		public string KeyFilename
		{
			get
			{
				return this.keyFilename;
			}
			set
			{
				this.keyFilename = value;
			}
		}
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}
		public string LogFilename
		{
			get
			{
				if (this.logFilename == null)
				{
					return "cybs.log";
				}
				return this.logFilename;
			}
			set
			{
				this.logFilename = value;
			}
		}
		public int LogMaximumSize
		{
			get
			{
				if (this.logMaximumSize == -1)
				{
					return 10;
				}
				return this.logMaximumSize;
			}
			set
			{
				this.logMaximumSize = value;
			}
		}
		public int Timeout
		{
			get
			{
				if (this.timeout == -1)
				{
					return 130;
				}
				return this.timeout;
			}
			set
			{
				this.timeout = value;
			}
		}
		public bool Demo
		{
			get
			{
				return this.demo && !this.sendToProduction && (this.serverURL == null || !this.serverURL.Contains("ics2ws.ic3.com"));
			}
			set
			{
				this.demo = value;
			}
		}
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
			set
			{
				this.connectionLimit = value;
			}
		}
		public string LogString
		{
			get
			{
				string buf = string.Empty;
				if (this.keysDirectory != null)
				{
					buf = buf + "keysDirectory=" + this.keysDirectory;
				}
				if (this.serverURL != null)
				{
					buf = buf + ",serverURL=" + this.serverURL;
				}
				else
				{
					buf = buf + ",sendToProduction=" + this.sendToProduction;
				}
				if (this.keyFilename != null)
				{
					buf = buf + ",keyFilename=" + this.keyFilename;
				}
				if (this.timeout != -1)
				{
					buf = buf + ",timeout=" + this.timeout;
				}
				if (this.connectionLimit != -1)
				{
					buf = buf + ",connectionLimit=" + this.connectionLimit;
				}
				return buf;
			}
		}
		internal string EffectiveServerURL
		{
			get
			{
				if (this.serverURL != null)
				{
					return this.serverURL;
				}
				if (!this.isSendToProductionSet)
				{
					throw new ApplicationException("CONFIGURATION BUG:  sendToProduction or serverURL must be specified!");
				}
				if (!this.sendToProduction)
				{
					return "https://ics2wstest.ic3.com/commerce/1.x/transactionProcessor";
				}
				return "https://ics2ws.ic3.com/commerce/1.x/transactionProcessor";
			}
		}
		internal string EffectiveKeyFilename
		{
			get
			{
				if (this.keyFilename == null)
				{
					return this.merchantID + ".p12";
				}
				return this.keyFilename;
			}
		}
		internal string EffectivePassword
		{
			get
			{
				if (this.password == null)
				{
					return this.merchantID;
				}
				return this.password;
			}
		}
		public string NonNullMerchantID
		{
			get
			{
				this.CheckMerchantID();
				return this.merchantID;
			}
		}
		public void setLogProperties(bool enableLog, string logDirectory)
		{
			if (enableLog && logDirectory == null)
			{
				throw new ApplicationException("CONFIGURATION BUG:  logDirectory is required when enableLog is true!");
			}
			this.enableLog = enableLog;
			this.logDirectory = logDirectory;
		}
		private void CheckMerchantID()
		{
			if (this.merchantID == null)
			{
				throw new ApplicationException("CONFIGURATION OR CODE BUG:  merchantID is missing!");
			}
		}
	}
}
