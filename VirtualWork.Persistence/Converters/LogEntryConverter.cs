using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Log.LogEntry;
using EntityType = VirtualWork.Persistence.Entities.LogEntry;

namespace VirtualWork.Persistence.Converters
{
	public class LogEntryConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public LogEntryConverter(EntityProvider<EntityType> entityProvider,
			UserRepository userRepository,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.UserId = dto.User?.Id;
			entity.LogLevel = (int)dto.LogLevel;
			entity.TimeStamp = dto.TimeStamp.GetRepositoryDateTimeFormat();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.User = userRepository.Get(entity.UserId);
			dto.LogLevel = (LogLevel)entity.LogLevel;
			dto.TimeStamp = entity.TimeStamp.GetViewDateTimeFormat();
		}
	}
}
