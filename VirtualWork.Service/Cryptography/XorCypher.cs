using System;
using System.Text;

namespace VirtualWork.Service.Cryptography
{
	public class XorCypher
	{
		public string Encrypt(string source, string password)
		{
			if (String.IsNullOrEmpty(password))
			{
				throw new ArgumentException("Password should not be empty.");
			}

			int i = 0, j = 0;
			var result = new StringBuilder();

			while (i < source.Length)
			{
				var appendChar = source[i] != password[j] ? (char)(source[i] ^ password[j]) : source[i];
				result.Append(appendChar);
				i++;
				j++;
				if (j >= password.Length)
				{
					j = 0;
				}
			}

			return result.ToString();
		}

		public byte[] Encrypt(byte[] source, byte[] password)
		{
			if ((password == null) || (password.Length == 0))
			{
				throw new ArgumentException("Password should not be empty.");
			}

			var result = new byte[source.Length];
			int i = 0, j = 0;

			while (i < source.Length)
			{
				result[i] = (byte)(source[i] ^ password[j]);
				i++;
				j++;
				if (j >= password.Length)
				{
					j = 0;
				}
			}

			return result;
		}
	}
}
