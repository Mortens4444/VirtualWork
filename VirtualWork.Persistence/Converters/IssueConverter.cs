using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Job.Issue;
using EntityType = VirtualWork.Persistence.Entities.Issue;

namespace VirtualWork.Persistence.Converters
{
	public class IssueConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly UserRepository userRepository;

		public IssueConverter(EntityProvider<EntityType> entityProvider,
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
			entity.ParentId = dto.Parent?.Id;
			entity.OwnerId = dto.Owner?.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Creator = userRepository.Get(entity.CreatorId);
			dto.Parent = ToDto(entityProvider.GetEntity(entity.ParentId));
			dto.Owner = userRepository.Get(entity.OwnerId);
		}
	}
}
