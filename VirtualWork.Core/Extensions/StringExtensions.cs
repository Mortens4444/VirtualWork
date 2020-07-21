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

		public static (string Application, string Parameters) GetExecutionParameters(this string applicationWithParameters)
		{
			if (String.IsNullOrEmpty(applicationWithParameters))
			{
				return (Application: String.Empty, Parameters: String.Empty);
			}

			var firstQuotationMarkIndex = applicationWithParameters.IndexOf('"');
			if (firstQuotationMarkIndex == 0)
			{
				var secondQuotationMarkIndex = applicationWithParameters.IndexOf('"', 1);
				return (Application: applicationWithParameters.Substring(1, secondQuotationMarkIndex - 1), Parameters: applicationWithParameters.Substring(secondQuotationMarkIndex + 2));
			}

			var firstSpaceIndex = applicationWithParameters.IndexOf(' ');
			return (Application: applicationWithParameters.Substring(0, firstSpaceIndex), Parameters: applicationWithParameters.Substring(firstSpaceIndex + 1));
		}
	}
}
