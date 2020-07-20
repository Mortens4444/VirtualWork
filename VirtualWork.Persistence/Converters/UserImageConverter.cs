using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Media.UserImage;
using EntityType = VirtualWork.Persistence.Entities.UserImage;

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
			entity.UserId = dto.User.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.User = userRepository.Get(entity.UserId);
		}
	}
}
