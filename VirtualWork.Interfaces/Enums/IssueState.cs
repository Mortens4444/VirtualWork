using System.ComponentModel;

namespace VirtualWork.Interfaces.Enums
{
	public enum IssueState
	{
		[Description("To do")]
		ToDo,

		[Description("In progress")]
		InProgress,

		[Description("Review")]
		UnderReview,

		[Description("Verification")]
		UnderVerification,

		Verified,

		Blocked,

		[Description("Done")]
		Cancelled,

		[Description("Done")]
		Done
	}
}