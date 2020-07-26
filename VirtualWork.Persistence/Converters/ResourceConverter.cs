using VirtualWork.Interfaces.Enums;
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
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ResourceType = (int)dto.ResourceType;
			entity.ActorId = dto.Actor.Id;
			entity.ActorType = (int)dto.ActorType;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.ResourceType = (ResourceType)entity.ResourceType;
			dto.ActorType = (ActorType)entity.ActorType;

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
