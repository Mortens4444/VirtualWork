using VirtualWork.Persistence.Helper;
using VirtualWork.Persistence.Repositories;
using DtoType = VirtualWork.Core.Other.Comment;
using EntityType = VirtualWork.Persistence.Entities.Comment;

namespace VirtualWork.Persistence.Converters
{
	public class CommentConverter : ConverterBase<DtoType, EntityType>
	{
		private readonly IssueRepository issueRepository;
		private readonly UserRepository userRepository;

		public CommentConverter(EntityProvider<EntityType> entityProvider,
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
			entity.UserId = dto.User.Id;
		}

		protected override void CopyTypeMismatchingEntityParameters(EntityType entity, DtoType dto)
		{
			dto.Issue = issueRepository.Get(entity.IssueId);
			dto.User = userRepository.Get(entity.UserId);
		}
	}
}
