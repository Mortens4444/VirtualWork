using System.Collections.Generic;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Interfaces.Actors
{
	public interface INotifiable : IHaveIdentifier
	{
		IEnumerable<IContactInfo> Contacts { get; set; }

		string Name { get; set; }

		IEmailAddress GetFirstEmailAddress();
	}
}