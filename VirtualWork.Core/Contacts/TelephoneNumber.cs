using VirtualWork.Core.Actors;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Contacts
{
	public class TelephoneNumber : ContactBase, ITelephoneNumber
	{
		public string Number { get; set; }
	}
}