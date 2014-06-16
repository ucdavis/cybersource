using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace CybsWSSecurityIOP
{
	[Guid("D77D1190-6E6A-4E88-9D32-3F62821308EF"), TypeLibType(4160)]
	[ComImport]
	public interface ISignature
	{
		[DispId(5)]
		int InternalFlag
		{
			[DispId(5)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(5)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
		[DispId(1610743808)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void OnStartPage([MarshalAs(UnmanagedType.IUnknown)] [In] object piUnk);
		[DispId(1610743809)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void OnEndPage();
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SignDocument([MarshalAs(UnmanagedType.Struct)] [In] object vrgbDocToSign, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPKCS12Filename, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPassphrase, [MarshalAs(UnmanagedType.Struct)] out object pvbstrSignedDoc);
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetVersion();
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object GetErrorMessage([In] int lReturnCode);
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int SignBSTRDocument([MarshalAs(UnmanagedType.BStr)] [In] string bstrDocToSign, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPKCS12Filename, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPassphrase, [MarshalAs(UnmanagedType.Struct)] out object pvbstrSignedDoc);
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void GetInternalNumbers([MarshalAs(UnmanagedType.Struct)] out object pvlFirst, [MarshalAs(UnmanagedType.Struct)] out object pvlSecond, [MarshalAs(UnmanagedType.Struct)] out object pvlThird);
	}
}
