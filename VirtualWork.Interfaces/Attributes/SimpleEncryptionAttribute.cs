namespace VirtualWork.Interfaces.Attributes
{
	public class SimpleEncryptionAttribute : EncryptionAttribute
	{
		public string EncryptionKey { get; }

		public SimpleEncryptionAttribute(string encryptionKey)
		{
			EncryptionKey = encryptionKey;
		}
	}
}
