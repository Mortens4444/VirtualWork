using System;
using System.Security.Cryptography;

namespace VirtualWork.Core.Security
{
	public class RandomGenerator
	{
		private readonly RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
		private readonly byte[] byteArray = new byte[4];

		public int Generate()
		{
			return Generate(0, Int32.MaxValue);
		}

		public int Generate(int maxValue)
		{
			return Generate(0, maxValue);
		}

		public int Generate(int minValue, int maxValue)
		{
			if (maxValue <= minValue)
			{
				throw new InvalidOperationException($"{nameof(maxValue)} cannot be smaller or equal than {nameof(minValue)}");
			}

			var range = (uint)(maxValue - minValue);

			provider.GetBytes(byteArray);

			var randomNumber= (uint)(BitConverter.ToUInt32(byteArray, 0) % maxValue);
			return (int)(minValue + randomNumber);
		}
	}
}
