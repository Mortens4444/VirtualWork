using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Contacts.Email;
using EntityType = VirtualWork.Persistence.Entities.Email;

namespace VirtualWork.Persistence.Converters
{
	public class EmailConverter : ConverterBase<DtoType, EntityType>
	{
		public EmailConverter(EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
		}
	}
}
