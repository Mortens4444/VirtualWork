namespace VirtualWork.Interfaces.Attributes
{
	public class SystemSpecificEncryptionAttribute : EncryptionAttribute
	{
		public string Salt { get; }

		public SystemSpecificEncryptionAttribute(string salt)
		{
			Salt = salt;
		}
	}
}
