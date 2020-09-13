using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Infrastructure.Resource;
using EntityType = VirtualWork.Persistence.Entities.Resource;

namespace VirtualWork.Persistence.Converters
{
	public class ResourceConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;
		
		public ResourceConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ActorId = dto.Actor.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			switch (dto.ActorType)
			{
				case ActorType.User:
					dto.Actor = userRepository.Get(entity.ActorId);
					break;
				case ActorType.Partner:
					break;
				default:
					break;
			}
		}
	}
}
