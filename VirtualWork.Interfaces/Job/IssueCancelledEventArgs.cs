namespace VirtualWork.Interfaces.Job
{
	public class IssueCancelledEventArgs
	{
		public IIssue Issue { get; set; }

		public IssueCancelledEventArgs(IIssue issue)
		{
			Issue = issue;
		}
	}
}
