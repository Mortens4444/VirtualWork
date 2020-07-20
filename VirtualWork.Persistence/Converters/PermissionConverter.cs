using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Security.Permission;
using EntityType = VirtualWork.Persistence.Entities.Permission;

namespace VirtualWork.Persistence.Converters
{
	public class PermissionConverter : ConverterBase<DtoType, EntityType>
	{
		public PermissionConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}
	}
}
