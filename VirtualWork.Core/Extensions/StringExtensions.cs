using System;

namespace VirtualWork.Core.Extensions
{
	public static class StringExtensions
	{
		public static bool ContainsIgnoreCase(this string text, string subString)
		{
			if (String.IsNullOrEmpty(text))
			{
				return false;
			}
			return text.IndexOf(subString, StringComparison.InvariantCultureIgnoreCase) > -1;
		}
	}
}
