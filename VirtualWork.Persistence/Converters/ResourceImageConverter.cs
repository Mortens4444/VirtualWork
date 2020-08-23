using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Media.ResourceImage;
using EntityType = VirtualWork.Persistence.Entities.ResourceImage;

namespace VirtualWork.Persistence.Converters
{
	public class ResourceImageConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly ResourceRepository resourceRepository;

		public ResourceImageConverter(EntityProvider<EntityType> entityProvider,
			ResourceRepository resourceRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.resourceRepository = resourceRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ResourceId = dto.Resource.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Resource = resourceRepository.Get(entity.ResourceId);
		}
	}
}
