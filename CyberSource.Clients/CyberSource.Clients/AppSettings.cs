using System;
using System.Configuration;
namespace CyberSource.Clients
{
	public class AppSettings
	{
		private const string CYBS_PREFIX = "cybs";
		private const string SEPARATOR = ".";
		private const string TRUE = "TRUE";
		private const string ONE = "1";
		public static string GetSetting(string merchantID, string key)
		{
			return AppSettings.GetSetting(merchantID, key, null);
		}
		public static string GetSetting(string merchantID, string key, string defaultVal)
		{
			string val = null;
			if (merchantID != null)
			{
				val = ConfigurationManager.AppSettings["cybs." + merchantID + "." + key];
				if (val == null)
				{
					val = ConfigurationManager.AppSettings[merchantID + "." + key];
				}
			}
			if (val == null)
			{
				val = ConfigurationManager.AppSettings["cybs." + key];
			}
			if (val == null)
			{
				val = ConfigurationManager.AppSettings[key];
			}
			if (val == null)
			{
				val = defaultVal;
			}
			return val;
		}
		public static int GetBoolSetting(string merchantID, string key)
		{
			string val = AppSettings.GetSetting(merchantID, key);
			if (val == null)
			{
				return -1;
			}
			if (!"1".Equals(val) && !"TRUE".Equals(val.ToUpper()))
			{
				return 0;
			}
			return 1;
		}
		public static int GetIntSetting(string merchantID, string key)
		{
			string val = AppSettings.GetSetting(merchantID, key);
			if (val != null)
			{
				return int.Parse(val);
			}
			return -1;
		}
	}
}
