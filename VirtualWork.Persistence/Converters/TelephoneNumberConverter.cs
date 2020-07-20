using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Contacts.TelephoneNumber;
using EntityType = VirtualWork.Persistence.Entities.TelephoneNumber;

namespace VirtualWork.Persistence.Converters
{
	public class TelephoneNumberConverter : ConverterBase<DtoType, EntityType>
	{
		public TelephoneNumberConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}
	}
}
