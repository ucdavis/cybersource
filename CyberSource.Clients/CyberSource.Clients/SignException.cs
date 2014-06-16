using CyberSource.WSSecurity;
using System;
namespace CyberSource.Clients
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
		public string LogString
		{
			get
			{
				return string.Concat(new object[]
				{
					base.GetType().FullName,
					":",
					Environment.NewLine,
					this.Message,
					Environment.NewLine,
					"Error Code: ",
					this.mErrorCode
				});
			}
		}
		internal SignException(CyberSource.WSSecurity.SignException se) : base(se.Message, se)
		{
			this.mErrorCode = se.ErrorCode;
		}
	}
}
