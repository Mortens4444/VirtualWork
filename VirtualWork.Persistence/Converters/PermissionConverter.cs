using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Security.Permission;
using EntityType = VirtualWork.Persistence.Entities.Permission;

namespace VirtualWork.Persistence.Converters
{
	public class PermissionConverter : ConverterBase<DtoType, EntityType>
	{
		public PermissionConverter(EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
		}
	}
}
