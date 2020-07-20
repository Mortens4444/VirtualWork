using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using IssueDto = VirtualWork.Core.Job.Issue;

namespace VirtualWork.Persistence.Repositories
{
	public class IssueRepository : RepositoryBase<IssueDto, Issue>
    {
        public IssueRepository(
			VirtualWorkDatabaseContext mtfDatabase,
			IssueConverter issueConverter)
            : base(mtfDatabase, issueConverter, mtfDatabase.Issues)
        {
        }
	}
}
