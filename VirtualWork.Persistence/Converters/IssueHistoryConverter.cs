using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Job.IssueHistory;
using EntityType = VirtualWork.Persistence.Entities.IssueHistory;

namespace VirtualWork.Persistence.Converters
{
	public class IssueHistoryConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly IssueRepository issueRepository;
		private readonly UserRepository userRepository;

		public IssueHistoryConverter(EntityProvider<EntityType> entityProvider,
			IssueRepository issueRepository,
			UserRepository userRepository,
			PropertyCopier propertyCopier,
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, propertyCopier, virtualWorkDatabaseContext)
		{
			this.issueRepository = issueRepository;
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.IssueId = dto.Issue.Id;
			entity.ModifierUserId = dto.ModifierUser.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Issue = issueRepository.Get(entity.IssueId);
			dto.ModifierUser = userRepository.Get(entity.ModifierUserId);
		}
	}
}
