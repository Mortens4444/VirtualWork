using VirtualWork.Core.Extensions;
using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Appointment.Event;
using EntityType = VirtualWork.Persistence.Entities.Event;

namespace VirtualWork.Persistence.Converters
{
	public class EventConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public EventConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.CreatorId = dto.Creator.Id;
			entity.StartApplication = $"{dto.ApplicationToStart} {dto.Arguments}";
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Creator = userRepository.Get(entity.CreatorId);
			var (application, parameters) = entity.StartApplication.GetExecutionParameters();
			dto.ApplicationToStart = application;
			dto.Arguments = parameters;
		}
	}
}
