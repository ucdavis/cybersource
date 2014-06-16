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
namespace CyberSource.Clients.NVPWebReference
{
	[GeneratedCode("System.Web.Services", "2.0.50727.42"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "INVPTransactionProcessor", Namespace = "urn:schemas-cybersource-com:transaction-data:TransactionProcessor")]
	public class NVPTransactionProcessor : SoapHttpClientProtocol
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
		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}
		public new bool UseDefaultCredentials
		{
			get
			{
				return base.UseDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		public NVPTransactionProcessor()
		{
			this.Url = "https://ics2wstest.ic3.com/commerce/1.x/transactionProcessor";
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
				return;
			}
			this.useDefaultCredentialsSetExplicitly = true;
		}
		[SoapDocumentMethod("runTransaction", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Bare)]
		[return: XmlElement("nvpReply", Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")]
		public string runTransaction([XmlElement(Namespace = "urn:schemas-cybersource-com:transaction-data-1.28")] string nvpRequest)
		{
			object[] results = base.Invoke("runTransaction", new object[]
			{
				nvpRequest
			});
			return (string)results[0];
		}
		public void runTransactionAsync(string nvpRequest)
		{
			this.runTransactionAsync(nvpRequest, null);
		}
		public void runTransactionAsync(string nvpRequest, object userState)
		{
			if (this.runTransactionOperationCompleted == null)
			{
				this.runTransactionOperationCompleted = new SendOrPostCallback(this.OnrunTransactionOperationCompleted);
			}
			base.InvokeAsync("runTransaction", new object[]
			{
				nvpRequest
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
		public new void CancelAsync(object userState)
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
