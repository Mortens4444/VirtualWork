using System.Collections.Generic;
using System.Linq;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Core.Actors
{
	public abstract class Actor : INotifiable, IHaveName
	{
		public int Id { get; set; }

		public IEnumerable<IContactInfo> Contacts { get; set; }

		public string Name { get; set; }

		public string OtherInformation { get; set; }

		public IEmailAddress GetFirstEmailAddress()
		{
			return GetFirstContact<IEmailAddress>();
		}

		public ITelephoneNumber GetFirstTelephoneNumber()
		{
			return GetFirstContact<ITelephoneNumber>();
		}

		public IAddress GetFirstAddress()
		{
			return GetFirstContact<IAddress>();
		}

		private TContectType GetFirstContact<TContectType>()
			where TContectType : class, IContactInfo
		{
			return Contacts.FirstOrDefault(contact => contact is TContectType) as TContectType;
		}
	}
}