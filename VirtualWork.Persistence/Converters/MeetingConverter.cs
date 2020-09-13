using VirtualWork.Persistence.Helper;
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
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.OwnerId = dto.Owner.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Owner = userRepository.Get(entity.OwnerId);
		}
	}
}
