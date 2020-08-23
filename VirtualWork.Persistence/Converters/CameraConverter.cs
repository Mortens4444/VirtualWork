using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Infrastructure.Camera;
using EntityType = VirtualWork.Persistence.Entities.Camera;

namespace VirtualWork.Persistence.Converters
{
	public class CameraConverter : ConverterBase<DtoType, EntityType>
	{
		public CameraConverter(EntityProvider<EntityType> entityProvider,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
		}
	}
}
