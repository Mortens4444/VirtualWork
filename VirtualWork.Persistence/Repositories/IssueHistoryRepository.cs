using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using IssueHistoryDto = VirtualWork.Core.Job.IssueHistory;

namespace VirtualWork.Persistence.Repositories
{
	public class IssueHistoryRepository : RepositoryBase<IssueHistoryDto, IssueHistory>
    {
        public IssueHistoryRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			IssueHistoryConverter issueHistoryConverter)
            : base(mtfDatabase, issueHistoryConverter, mtfDatabase.IssueHistoryEntries)
        {
        }
	}
}
