using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces.Job
{
	public interface IIssue
	{
		int Id { get; set; }

		IssueType IssueType { get; set; }

		IssueState IssueState { get; set; }

		bool IsBlocked { get; set; }

		bool IsVerified { get; set; }
	}
}
