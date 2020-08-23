using System.Linq;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Infrastructure.Server;
using EntityType = VirtualWork.Persistence.Entities.Server;

namespace VirtualWork.Persistence.Converters
{
	public class ServerConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly CameraConverter cameraConverter;

		public ServerConverter(EntityProvider<EntityType> entityProvider,
			CameraConverter cameraConverter,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.cameraConverter = cameraConverter;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.Cameras = dto.Cameras?.Select(cameraConverter.ToEntity).ToList();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Cameras = entity.Cameras?.Select(cameraConverter.ToDto).ToList();
			//dto.Cameras = cameraRepository.GetMany(camera => camera.ServerId == entity.Id);
		}
	}
}
