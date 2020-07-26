using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Media.ActorImage;
using EntityType = VirtualWork.Persistence.Entities.ActorImage;

namespace VirtualWork.Persistence.Converters
{
	public class UserImageConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public UserImageConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.ActorId = dto.Actor.Id;
			entity.ActorType = (int)dto.ActorType;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Actor = userRepository.Get(entity.ActorId);
			dto.ActorType = (ActorType)entity.ActorType;
		}
	}
}
