using VirtualWork.Core.Actors;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Contacts
{
	public class Email : ContactBase, IEmailAddress
	{
		public string Address { get; set; }
	}
}