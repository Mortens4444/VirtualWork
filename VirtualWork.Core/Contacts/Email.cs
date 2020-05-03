using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Contacts
{
	public class Email : IContactInfo
	{
		public int Id { get; set; }

		public string Address { get; set; }
	}
}