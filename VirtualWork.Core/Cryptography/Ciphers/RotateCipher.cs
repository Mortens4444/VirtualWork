using System.Text;

namespace VirtualWork.Core.Cryptography.Ciphers
{
	public class RotateCipher
	{
		public string Encrypt(string source, int rotateKey)
		{
			int i = 0, j = 0;
			var result = new StringBuilder(source);

			while (rotateKey > source.Length)
			{
				rotateKey -= source.Length;
			}
			while (rotateKey < -source.Length)
			{
				rotateKey += source.Length;
			}

			if (rotateKey > 0) // rotate right
			{
				j = rotateKey;
				while (i < source.Length)
				{
					while (j >= source.Length)
					{
						j -= source.Length;
					}
					result[j] = source[i];
					i++;
					j++;
				}
			}
			else if (rotateKey < 0) // rotate left
			{
				i += -rotateKey;
				while (j < source.Length)
				{
					while (i >= source.Length)
					{
						i -= source.Length;
					}
					result[j] = source[i];
					i++;
					j++;
				}
			}

			return result.ToString();
		}
	}
}
