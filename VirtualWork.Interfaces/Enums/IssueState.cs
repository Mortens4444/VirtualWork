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

		[Description("Done")]
		Cancelled,

		[Description("Done")]
		Done
	}
}