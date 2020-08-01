using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Appointment.Meeting;
using EntityType = VirtualWork.Persistence.Entities.Meeting;

namespace VirtualWork.Persistence.Converters
{
	public class MeetingConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public MeetingConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.OwnerId = dto.Owner.Id;
			entity.RepeationType = (int)dto.RepeationType;

			entity.CreationDate = dto.CreationDate.GetRepositoryDateTimeFormat();
			entity.MeetingDate = dto.MeetingDate.GetRepositoryDateTimeFormat();
			entity.ExpirationDate = dto.ExpirationDate?.GetRepositoryDateTimeFormat();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Owner = userRepository.Get(entity.OwnerId);
			dto.RepeationType = (RepeationType)entity.RepeationType;

			dto.CreationDate = entity.CreationDate.GetViewDateTimeFormat();
			dto.MeetingDate = entity.MeetingDate.GetViewDateTimeFormat();
			dto.ExpirationDate = entity.ExpirationDate?.GetViewDateTimeFormat();
		}
	}
}
