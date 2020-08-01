namespace VirtualWork.Interfaces.Job
{
	public class IssueBlockedStateChangedEventArgs
	{
		public IIssue Issue { get; set; }

		public bool IsBlocked { get; set; }

		public IssueBlockedStateChangedEventArgs(IIssue issue, bool isBlocked)
		{
			Issue = issue;
			IsBlocked = isBlocked;
		}
	}
}
