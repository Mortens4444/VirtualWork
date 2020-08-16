namespace VirtualWork.Core.Cryptography.Ciphers.Production
{
	public class ProductionCipherKey
	{
		public int ReplaceKey { get; set; }

		public int RotateKey { get; set; }

		public string Password { get; set; }

		public ProductionCipherKey(string password)
			: this(password.Length, password.Length, password)
		{ }

		public ProductionCipherKey(int replaceKey, int rotateKey, string password)
		{
			ReplaceKey = replaceKey;
			RotateKey = rotateKey;
			Password = password;
		}

		public static implicit operator ProductionCipherKey(string password) => new ProductionCipherKey(password);
	}
}
