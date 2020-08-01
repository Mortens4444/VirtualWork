using VirtualWork.Core.Extensions;
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
			VirtualWorkDatabaseContext virtualWorkDatabaseContext)
			: base(entityProvider, virtualWorkDatabaseContext)
		{
			this.issueRepository = issueRepository;
			this.userRepository = userRepository;
		}

		protected override void CopyTypeMismatchingDtoParameters(DtoType dto, EntityType entity)
		{
			entity.IssueId = dto.Issue.Id;
			entity.ModifierUserId = dto.ModifierUser.Id;

			entity.ModifyDate = dto.ModifyDate.GetRepositoryDateTimeFormat();
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Issue = issueRepository.Get(entity.IssueId);
			dto.ModifierUser = userRepository.Get(entity.ModifierUserId);

			dto.ModifyDate = entity.ModifyDate.GetViewDateTimeFormat();
		}
	}
}
