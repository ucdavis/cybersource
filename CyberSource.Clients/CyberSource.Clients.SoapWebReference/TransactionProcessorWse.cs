using Microsoft.Web.Services3;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace CyberSource.Clients.SoapWebReference
{
	[GeneratedCode("System.Web.Services", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "ITransactionProcessor", Namespace = "urn:schemas-cybersource-com:transaction-data:TransactionProcessor")]
	public class TransactionProcessorWse : WebServicesClientProtocol
	{
		private SendOrPostCallback runTransactionOperationCompleted;
		private bool useDefaultCredentialsSetExplicitly;
		public event runTransactionCompletedEventHandler runTransactionCompleted
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.runTransactionCompleted = (runTransactionCompletedEventHandler)Delegate.Combine(this.runTransactionCompleted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.runTransactionCompleted = (runTransactionCompletedEventHandler)Delegate.Remove(this.runTransactionCompleted, value);
			}
		}
		public string Url
		{
			get
			{
				return base.get_Url();
			}
			set
			{
				if (this.IsLocalFileSystemWebService(base.get_Url()) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.set_UseDefaultCredentials(false);
				}
				base.set_Url(value);
			}
		}
		public bool UseDefaultCredentials
		{
			get
			{
				return base.get_UseDefaultCredentials();
			}
			set
			{
				base.set_UseDefaultCredentials(value);
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		public TransactionProcessorWse(string url)
		{
			this.Url = url;
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
				return;
			}
			this.useDefaultCredentialsSetExplicitly = true;
		}
		[SoapDocumentMethod("runTransaction", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
		[return: XmlElement("replyMessage", Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
		public ReplyMessage runTransaction([XmlElement(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")] RequestMessage requestMessage)
		{
			object[] results = base.Invoke("runTransaction", new object[]
			{
				requestMessage
			});
			return (ReplyMessage)results[0];
		}
		public void runTransactionAsync(RequestMessage requestMessage)
		{
			this.runTransactionAsync(requestMessage, null);
		}
		public void runTransactionAsync(RequestMessage requestMessage, object userState)
		{
			if (this.runTransactionOperationCompleted == null)
			{
				this.runTransactionOperationCompleted = new SendOrPostCallback(this.OnrunTransactionOperationCompleted);
			}
			base.InvokeAsync("runTransaction", new object[]
			{
				requestMessage
			}, this.runTransactionOperationCompleted, userState);
		}
		private void OnrunTransactionOperationCompleted(object arg)
		{
			if (this.runTransactionCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.runTransactionCompleted(this, new runTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		public void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}
		private bool IsLocalFileSystemWebService(string url)
		{
			if (url == null || url == string.Empty)
			{
				return false;
			}
			Uri wsUri = new Uri(url);
			return wsUri.Port >= 1024 && string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
		}
	}
}
