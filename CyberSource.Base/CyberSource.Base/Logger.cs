using System;
using System.Collections;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Xml;
namespace CyberSource.Base
{
	public class Logger
	{
		public enum LogType
		{
			FILESTART,
			TRANSTART,
			CONFIG,
			REQUEST,
			REPLY,
			FAULT,
			EXCEPTION
		}
		private const int MUTEX_TIMEOUT = 10000;
		private const long MB = 1048576L;
		private const string TRANSTART_MARKER = "===============================================================================";
		private const string NULL_ENTRY = "(null)";
		private const string FILESTART_ENTRY = "CYBERSOURCE LOG FILE";
		private const string TRANSTART_ENTRY = "";
		private const string LINEFEED = "\n";
		private const string CARRIAGE_RETURN = "\r";
		private const string NEWLINE = "\r\n";
		private const string ARCHIVE_EXT_FORMAT = ".{0:D4}-{1:D2}-{2:D2}T{3:D2}{4:D2}{5:D2}";
		private const string LOG_ENTRY_FORMAT = "{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}.{6:D3} {7:D5} {8}> {9}{10}{11}";
		private const string DEMO_REQUEST_HEADER = "REQUEST:\r\n";
		private const string DEMO_REPLY_HEADER = "REPLY:\r\n";
		private const string UNDERSCORE = "_";
		private const string CYBS_ROOT_FIELDS = "requestMessage replyMessage nvpRequest nvpReply";
		private const char NV_SEPARATOR = '=';
		private const string NVP_SEPARATOR = "\r\n";
		private const string TRACK_DATA = "trackData";
		private const char MASK_CHAR = 'x';
		private static Mutex smMutex;
		private static bool forceArchive;
		private static Type WebExceptionType;
		private string mPath;
		static Logger()
		{
			Logger.smMutex = new Mutex(false, "CyberSource.Base.Logger");
			Logger.WebExceptionType = typeof(WebException);
			Logger.forceArchive = (ConfigurationManager.AppSettings["forceArchive"] != null);
		}
		private Logger()
		{
		}
		public static Logger GetInstance(string directory, string filename, int maxSizeInMB)
		{
			if (Logger.AcquireMutexWithTimeout())
			{
				FileStream stream = null;
				try
				{
					Logger logger = new Logger();
					logger.mPath = Path.Combine(directory, filename);
					stream = new FileStream(logger.mPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
					long size = stream.Length;
					if (size > (long)maxSizeInMB * 1048576L || Logger.forceArchive)
					{
						stream.Close();
						File.Move(logger.mPath, Logger.FormatArchiveName(logger.mPath));
						stream = new FileStream(logger.mPath, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite);
						size = 0L;
					}
					if (size == 0L)
					{
						logger.Log(Logger.LogType.FILESTART, "CYBERSOURCE LOG FILE");
					}
					Logger result = logger;
					return result;
				}
				catch (IOException)
				{
					Logger result = null;
					return result;
				}
				finally
				{
					Logger.CloseStreamAndReleaseMutex(stream);
				}
			}
			return null;
		}
		public void Log(Logger.LogType type, string text)
		{
			if (Logger.AcquireMutexWithTimeout())
			{
				FileStream stream = null;
				try
				{
					stream = new FileStream(this.mPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
					if (type == Logger.LogType.TRANSTART)
					{
						this.LogString(stream, "\r\n===============================================================================\r\n");
					}
					string logText = (text != null) ? text : "(null)";
					if (logText.Contains("\n") && !logText.Contains("\r"))
					{
						logText = logText.Replace("\n", "\r\n");
					}
					this.LogString(stream, this.FormatEntry(type, logText));
				}
				catch (Exception)
				{
				}
				finally
				{
					Logger.CloseStreamAndReleaseMutex(stream);
				}
			}
		}
		public void LogTransactionStart(string configString)
		{
			if (Logger.AcquireMutexWithTimeout())
			{
				try
				{
					this.Log(Logger.LogType.TRANSTART, "");
					this.Log(Logger.LogType.CONFIG, configString);
				}
				finally
				{
					Logger.smMutex.ReleaseMutex();
				}
			}
		}
		public void LogException(Exception e)
		{
			string webExceptionStatus = string.Empty;
			if (Logger.WebExceptionType.Equals(e.GetType()))
			{
				WebException we = (WebException)e;
				webExceptionStatus = " " + we.Status;
			}
			this.Log(Logger.LogType.EXCEPTION, string.Concat(new string[]
			{
				e.GetType().FullName,
				":",
				webExceptionStatus,
				"\r\n",
				e.Message,
				"\r\n",
				e.StackTrace
			}));
		}
		public void LogException(string logString)
		{
			this.Log(Logger.LogType.EXCEPTION, logString);
		}
		public void LogFault(string logString)
		{
			this.Log(Logger.LogType.FAULT, logString);
		}
		public void LogSoapException(SoapException se)
		{
			this.Log(Logger.LogType.FAULT, string.Concat(new object[]
			{
				se.Code,
				"\r\n",
				se.Message,
				"\r\nDetail: ",
				(se.Detail != null) ? se.Detail.OuterXml : "<null>"
			}));
		}
		public void LogRequest(Hashtable request, bool demo)
		{
			string logString = Logger.GetLogString(SafeFields.MessageType.REQUEST, request);
			if (demo)
			{
				Console.WriteLine("REQUEST:\r\n" + logString + "\r\n");
			}
			this.Log(Logger.LogType.REQUEST, logString);
		}
		public void LogReply(Hashtable reply, bool demo)
		{
			string logString = Logger.GetLogString(SafeFields.MessageType.REPLY, reply);
			if (demo)
			{
				Console.WriteLine("REPLY:\r\n" + logString + "\r\n");
			}
			this.Log(Logger.LogType.REPLY, logString);
		}
		public void LogRequest(XmlNode request, bool demo)
		{
			request = request.CloneNode(true);
			Logger.MaskXml(SafeFields.MessageType.REQUEST, request, null);
			string logString = request.OuterXml;
			if (demo)
			{
				Console.WriteLine("REQUEST:\r\n" + logString + "\r\n");
			}
			this.Log(Logger.LogType.REQUEST, logString);
		}
		public void LogReply(XmlNode reply, bool demo)
		{
			reply = reply.CloneNode(true);
			Logger.MaskXml(SafeFields.MessageType.REPLY, reply, null);
			string logString = reply.OuterXml;
			if (demo)
			{
				Console.WriteLine("REPLY:\r\n" + logString + "\r\n");
			}
			this.Log(Logger.LogType.REPLY, logString);
		}
		private static void MaskXml(SafeFields.MessageType type, XmlNode node, string parentName)
		{
			if (node == null)
			{
				return;
			}
			XmlNodeType nodeType = node.NodeType;
			if (nodeType == XmlNodeType.Text)
			{
				if (!SafeFields.IsSafe(type, parentName))
				{
					string origVal = node.Value;
					if (origVal != null)
					{
						origVal = origVal.Trim();
					}
					if (origVal != null && origVal.Length > 0)
					{
						node.Value = Logger.MaskedValue(parentName, origVal);
						return;
					}
				}
			}
			else
			{
				if (nodeType == XmlNodeType.Element || nodeType == XmlNodeType.Document)
				{
					if (!node.HasChildNodes)
					{
						return;
					}
					string localName = node.LocalName;
					if (localName == null)
					{
						localName = string.Empty;
					}
					string fieldFullName = null;
					if (parentName == null)
					{
						if (localName.Length > 0 && "requestMessage replyMessage nvpRequest nvpReply".IndexOf(localName) != -1)
						{
							fieldFullName = "";
						}
					}
					else
					{
						if (parentName.Length == 0)
						{
							fieldFullName = localName;
						}
						else
						{
							fieldFullName = parentName + "_" + localName;
						}
					}
					XmlNodeList children = node.ChildNodes;
					foreach (XmlNode child in children)
					{
						Logger.MaskXml(type, child, fieldFullName);
					}
				}
			}
		}
		private static bool AcquireMutexWithTimeout()
		{
			return Logger.smMutex.WaitOne(10000, false);
		}
		private static void CloseStreamAndReleaseMutex(FileStream stream)
		{
			try
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			catch (IOException)
			{
			}
			finally
			{
				Logger.smMutex.ReleaseMutex();
			}
		}
		private void LogString(FileStream stream, string text)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			stream.Write(bytes, 0, bytes.Length);
		}
		private static string FormatArchiveName(string path)
		{
			DateTime now = DateTime.Now;
			string ext = string.Format(".{0:D4}-{1:D2}-{2:D2}T{3:D2}{4:D2}{5:D2}", new object[]
			{
				now.Year,
				now.Month,
				now.Day,
				now.Hour,
				now.Minute,
				now.Second
			});
			return path + ext;
		}
		private string FormatEntry(Logger.LogType type, string text)
		{
			DateTime now = DateTime.Now;
			return string.Format("{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}.{6:D3} {7:D5} {8}> {9}{10}{11}", new object[]
			{
				now.Year,
				now.Month,
				now.Day,
				now.Hour,
				now.Minute,
				now.Second,
				now.Millisecond,
				Thread.CurrentThread.GetHashCode(),
				type.ToString().PadRight(10),
				text.Contains("\n") ? "\r\n" : string.Empty,
				text,
				"\r\n"
			});
		}
		private static string GetLogString(SafeFields.MessageType type, Hashtable table)
		{
			if (table == null || table.Count == 0)
			{
				return string.Empty;
			}
			StringBuilder sb = new StringBuilder();
			foreach (string key in table.Keys)
			{
				if (sb.Length > 0)
				{
					sb.Append("\r\n");
				}
				sb.Append(key);
				sb.Append('=');
				sb.Append(SafeFields.IsSafe(type, key) ? ((string)table[key]) : Logger.MaskedValue(key, (string)table[key]));
			}
			return sb.ToString();
		}
		public static string MaskedValue(string key, string val)
		{
			if (val == null)
			{
				return "(null)";
			}
			int len = val.Length;
			if (len == 0)
			{
				return string.Empty;
			}
			if (key.Contains("trackData") || (len >= 1 && len <= 9))
			{
				return new string('x', val.Length);
			}
			if (len >= 10 && len <= 15)
			{
				return val.Substring(0, 2) + new string('x', len - 4) + val.Substring(len - 2);
			}
			return val.Substring(0, 4) + new string('x', len - 8) + val.Substring(len - 4);
		}
	}
}
