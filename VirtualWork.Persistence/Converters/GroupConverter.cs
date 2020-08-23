using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Security.Group;
using EntityType = VirtualWork.Persistence.Entities.Group;

namespace VirtualWork.Persistence.Converters
{
	public class GroupConverter : ConverterBase<DtoType, EntityType>
	{
		public GroupConverter(EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
		}
	}
}
