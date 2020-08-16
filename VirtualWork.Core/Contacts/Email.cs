using VirtualWork.Core.Actors;
using VirtualWork.Interfaces.Contacts;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Contacts
{
	public class Email : ContactBase, IEmailAddress
	{
		public string Address { get; set; }

		public int ActorId { get; set; }

		public ActorType ActorType { get; set; }
	}
}