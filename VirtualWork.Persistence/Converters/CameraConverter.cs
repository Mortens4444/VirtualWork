using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Infrastructure.Camera;
using EntityType = VirtualWork.Persistence.Entities.Camera;

namespace VirtualWork.Persistence.Converters
{
	public class CameraConverter : ConverterBase<DtoType, EntityType>
	{
		public CameraConverter(EntityProvider<EntityType> entityProvider,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
		}
	}
}
