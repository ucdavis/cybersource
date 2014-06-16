using System;
namespace CyberSource.WSSecurity
{
	public class SignException : ApplicationException
	{
		private int mErrorCode;
		public int ErrorCode
		{
			get
			{
				return this.mErrorCode;
			}
		}
		internal SignException(int errorCode, string message) : base(message)
		{
			this.mErrorCode = errorCode;
		}
	}
}
