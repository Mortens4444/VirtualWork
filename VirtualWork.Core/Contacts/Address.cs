using VirtualWork.Core.Enums;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Contacts
{
	public class Address : IContactInfo
	{
		public int Id { get; set; }

		public string City { get; set; }

		public string Country { get; set; }

		public string Number { get; set; }

		public string PublicArea { get; set; }

		public PublicAreaKind PublicAreaKind { get; set; }
	}
}