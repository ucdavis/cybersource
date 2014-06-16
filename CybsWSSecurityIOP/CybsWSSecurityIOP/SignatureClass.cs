using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace CybsWSSecurityIOP
{
	[ClassInterface(0), Guid("698BFD43-76AA-4D13-98FE-5BE9FF5E05B8"), TypeLibType(2)]
	[ComImport]
	public class SignatureClass : ISignature, Signature
	{
		[DispId(5)]
		public virtual extern int InternalFlag
		{
			[DispId(5)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(5)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern SignatureClass();
		[DispId(1610743808)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void OnStartPage([MarshalAs(UnmanagedType.IUnknown)] [In] object piUnk);
		[DispId(1610743809)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void OnEndPage();
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SignDocument([MarshalAs(UnmanagedType.Struct)] [In] object vrgbDocToSign, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPKCS12Filename, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPassphrase, [MarshalAs(UnmanagedType.Struct)] out object pvbstrSignedDoc);
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public virtual extern object GetVersion();
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public virtual extern object GetErrorMessage([In] int lReturnCode);
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern int SignBSTRDocument([MarshalAs(UnmanagedType.BStr)] [In] string bstrDocToSign, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPKCS12Filename, [MarshalAs(UnmanagedType.BStr)] [In] string bstrPassphrase, [MarshalAs(UnmanagedType.Struct)] out object pvbstrSignedDoc);
		[DispId(6)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void GetInternalNumbers([MarshalAs(UnmanagedType.Struct)] out object pvlFirst, [MarshalAs(UnmanagedType.Struct)] out object pvlSecond, [MarshalAs(UnmanagedType.Struct)] out object pvlThird);
	}
}
