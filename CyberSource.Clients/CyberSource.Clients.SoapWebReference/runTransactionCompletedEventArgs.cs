using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Web.Services", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough]
	public class runTransactionCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public ReplyMessage Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (ReplyMessage)this.results[0];
			}
		}
		internal runTransactionCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
