using System.Collections.Generic;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Actors
{
	public abstract class Actor : INotifiable
	{
		public int Id { get; set; }

		public IEnumerable<IContactInfo> Contacts { get; set; }

		public string Name { get; set; }
	}
}