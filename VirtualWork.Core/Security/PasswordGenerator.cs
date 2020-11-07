using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWork.Core.Security
{
	public class PasswordGenerator
	{
		private readonly RandomGenerator randomGenerator = new RandomGenerator();

		public string Generate()
		{
			var passwordLength = randomGenerator.Generate(10, 14);
			return Generate(passwordLength);
		}

		public string Generate(int passwordLength)
		{
			var stringBuilder = new StringBuilder(passwordLength);
			for (int i = 0; i < passwordLength; i++)
			{
				stringBuilder.Append((char)randomGenerator.Generate(33, 127));
			}
			return stringBuilder.ToString();
		}
	}
}
