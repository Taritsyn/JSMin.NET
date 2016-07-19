using System.Runtime.CompilerServices;

namespace DouglasCrockford.JsMin.Utilities
{
	/// <summary>
	/// Extensions for Char
	/// </summary>
	internal static class CharExtensions
	{
		[MethodImpl((MethodImplOptions)256 /* AggressiveInlining */)]
		public static bool IsWhitespace(this char source)
		{
			return source == ' ' || (source >= '\t' && source <= '\r');
		}
	}
}