using System.Collections.Generic;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Interfaces.Actors
{
	public interface INotifiable
	{
		IEnumerable<IContactInfo> Contacts { get; set; }

		string Name { get; set; }
	}
}