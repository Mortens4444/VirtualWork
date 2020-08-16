﻿using System;
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

		public static string Encode(string plainString)
		{
			if (plainString == null)
			{
				throw new ArgumentNullException(nameof(plainString));
			}
			var encBytes = Encoding.UTF8.GetBytes(plainString);
			return Convert.ToBase64String(encBytes);
		}

		public static string Decode(string encodedString)
		{
			if (encodedString == null)
			{
				throw new ArgumentNullException(nameof(encodedString));
			}
			var decBytes = Convert.FromBase64String(encodedString);
			return Encoding.UTF8.GetString(decBytes);
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
