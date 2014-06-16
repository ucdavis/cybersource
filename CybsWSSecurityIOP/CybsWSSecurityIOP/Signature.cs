using System;
using System.Runtime.InteropServices;
namespace CybsWSSecurityIOP
{
	[CoClass(typeof(SignatureClass)), Guid("D77D1190-6E6A-4E88-9D32-3F62821308EF")]
	[ComImport]
	public interface Signature : ISignature
	{
	}
}
