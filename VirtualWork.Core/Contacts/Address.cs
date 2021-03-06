using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Contacts;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Contacts
{
	public class Address : ContactBase, IAddress, IHaveEntityOwner
	{
		public string City { get; set; }

		public string Country { get; set; }

		public string Number { get; set; }

		public string PublicArea { get; set; }

		public string FullAddress { get; set; }

		public PublicAreaKind PublicAreaKind { get; set; }

		public int EntityId { get; set; }

		public EntityType EntityType { get; set; }
	}
}