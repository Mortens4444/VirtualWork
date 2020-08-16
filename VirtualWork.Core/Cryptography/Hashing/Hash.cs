using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using VirtualWork.Core.Cryptography.Ciphers;

namespace VirtualWork.Core.Cryptography.Hashing
{
	public class Hash
	{
		/// <summary>
		/// Creates MD5 hash (128 bit - 16 byte)
		/// </summary>
		/// <param name="input">The string we want to hash</param>
		/// <returns>MD5 hash code</returns>
		public static string MD5_Hash(string input)
		{
			return CreateHash(MD5.Create(), input);
		}

		/// <summary>
		/// Creates SHA-1 hash (160 bit - 20 byte)
		/// </summary>
		/// <param name="input">The string we want to hash</param>
		/// <returns>SHA-1 hash code</returns>
		public static string SHA1_Hash(string input)
		{
			return CreateHash(new SHA1CryptoServiceProvider(), input);
		}

		/// <summary>
		/// Creates SHA-2 hash (512 bit - 64 byte)
		/// </summary>
		/// <param name="input">The string we want to hash</param>
		/// <returns>SHA-2 hash code</returns>
		public static string SHA2_Hash(string input)
		{
			return CreateHash(new SHA512Managed(), input);
		}

		public static string CreateHash(HashAlgorithm hashAlgorithm, string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException(nameof(input));
			}
			var sb = new StringBuilder();
			var hashBytes = hashAlgorithm.ComputeHash(Encoding.Default.GetBytes(input));
			foreach (var hashByte in hashBytes)
			{
				sb.Append(hashByte.ToString("x2"));
			}
			return sb.ToString();
		}

		public static string SHA2_FileHash(string filePath)
		{
			return CreateHash(filePath, new SHA512Managed());
		}

		public static string GetSaltedPasswordHash(string password)
		{
			var xorPassword = new byte[2];
			var random = new Random(Environment.TickCount);
			random.NextBytes(xorPassword);
			var byteXorCipher = new ByteXorCipher(xorPassword);
			return GetSaltedPasswordHash(byteXorCipher, password);
		}

		public static string GetSaltedPasswordHash(ByteXorCipher byteXorCipher, string password)
		{
			var bytes = Encoding.UTF8.GetBytes(password);
			var encryptedBytes = byteXorCipher.Encrypt(bytes).ToArray();
			var enryptedString = Encoding.UTF8.GetString(encryptedBytes);
			return Hash.SHA2_Hash(enryptedString);
		}

		private static string CreateHash(string filePath, HashAlgorithm hashAlgorithm)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException($"File not found: {filePath}", filePath);
			}
			string result;
			using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				file.Position = 0;
				var hash = hashAlgorithm.ComputeHash(file);
				result = BitConverter.ToString(hash);
				file.Close();
			}
			return result;
		}
	}
}
