using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Interfaces.Job
{
	public class IssueStateChangedEventArgs
	{
		public IIssue Issue { get; set; }

		public IssueState PreviousState { get; set; }

		public IssueStateChangedEventArgs(IIssue issue, IssueState previousState)
		{
			Issue = issue;
			PreviousState = previousState;
		}
	}
}
