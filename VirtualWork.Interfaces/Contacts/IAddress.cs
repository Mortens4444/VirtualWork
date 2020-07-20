using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces.Contacts
{
	public interface IAddress : IContactInfo
	{
		string City { get; set; }

		string Country { get; set; }

		string Number { get; set; }

		string PublicArea { get; set; }

		string FullAddress { get; set; }

		PublicAreaKind PublicAreaKind { get; set; }
	}
}
