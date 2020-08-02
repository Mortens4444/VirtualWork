using System.Text;

namespace VirtualWork.Core.Cryptography
{
	public class CaesarCypher
	{
		public string Encrypt(string source, int replaceKey)
		{
			var result = new StringBuilder(source);

			for (var i = 0; i < result.Length; i++)
			{
				var newChar = (char)(source[i] + replaceKey);
				result[i] = newChar != 0 ? newChar : source[i];
			}

			return result.ToString();
		}

		public byte[] Encrypt(byte[] source, int replaceKey)
		{
			var result = new byte[source.Length];

			for (var i = 0; i < result.Length; i++)
			{
				result[i] = (byte)(source[i] + replaceKey);
			}

			return result;
		}
	}
}
