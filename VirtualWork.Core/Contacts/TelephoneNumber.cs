using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Contacts
{
	public class TelephoneNumber : IContactInfo
	{
		public int Id { get; set; }

		public string Number { get; set; }
	}
}