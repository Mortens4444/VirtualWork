using System;
using System.Text;

namespace VirtualWork.Core.Cryptography.Coders
{
	public static class Base64
	{
		public static string Encode(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException(nameof(bytes));
			}
			return Convert.ToBase64String(bytes);
		}

		public static string Encode(string plainString, Encoding encoding = null)
		{
			if (plainString == null)
			{
				throw new ArgumentNullException(nameof(plainString));
			}
			var actualEncoding = encoding ?? Encoding.UTF8;
			var encBytes = actualEncoding.GetBytes(plainString);
			return Convert.ToBase64String(encBytes);
		}

		public static string Decode(string encodedString, Encoding encoding = null)
		{
			if (encodedString == null)
			{
				throw new ArgumentNullException(nameof(encodedString));
			}
			var decBytes = Convert.FromBase64String(encodedString);
			var actualEncoding = encoding ?? Encoding.UTF8;
			return actualEncoding.GetString(decBytes);
		}

		public static byte[] DecodeToArray(string encodedString)
		{
			if (encodedString == null)
			{
				throw new ArgumentNullException(nameof(encodedString));
			}
			return Convert.FromBase64String(encodedString);
		}

		public static string Encode(string plainString, bool trimEqualSigns)
		{
			var result = Encode(plainString);
			return trimEqualSigns ? result.TrimEnd('=') : result;
		}
	}

}
