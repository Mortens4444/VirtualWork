namespace VirtualWork.Interfaces.Job
{
	public class IssueVerifiedStateChangedEventArgs
	{
		public IIssue Issue { get; set; }

		public bool IsVerified { get; set; }

		public IssueVerifiedStateChangedEventArgs(IIssue issue, bool isVerified)
		{
			Issue = issue;
			IsVerified = isVerified;
		}
	}
}
