namespace VirtualWork.Core.Cryptography.Ciphers.Production
{
	public class ProductionCipher
	{
		private readonly CaesarCipher caesarCipher;
		private readonly RotateCipher rotateCipher;
		private readonly XorCipher xorCipher;

		public ProductionCipher(CaesarCipher caesarCipher,
			RotateCipher rotateCipher,
			XorCipher xorCipher)
		{
			this.caesarCipher = caesarCipher;
			this.rotateCipher = rotateCipher;
			this.xorCipher = xorCipher;
		}

		public string Encrypt(string plainText, ProductionCipherKey productionCipherKey)
		{
			return xorCipher.Encrypt(rotateCipher.Encrypt(caesarCipher.Encrypt(plainText, productionCipherKey.ReplaceKey), productionCipherKey.RotateKey), productionCipherKey.Password);
		}

		public string Decrypt(string cipherText, ProductionCipherKey productionCipherKey)
		{
			return caesarCipher.Encrypt(rotateCipher.Encrypt(xorCipher.Encrypt(cipherText, productionCipherKey.Password), -productionCipherKey.RotateKey), -productionCipherKey.ReplaceKey);
		}
	}
}
