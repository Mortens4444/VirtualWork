using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Settings.UserSetting;
using EntityType = VirtualWork.Persistence.Entities.UserSetting;

namespace VirtualWork.Persistence.Converters
{
	public class UserSettingConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public UserSettingConverter(EntityProvider<EntityType> entityProvider,
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
