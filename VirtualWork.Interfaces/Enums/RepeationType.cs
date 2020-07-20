using System.ComponentModel;

namespace VirtualWork.Interfaces.Enums
{
	public enum RepeationType
	{
		[Description("No repetition")]
		NoRepeat,

		[Description("Every x millisecond(s)")]
		EveryMillisecond,

		[Description("Every x second(s)")]
		EverySecond,

		[Description("Every x minute(s)")]
		EveryMinute,

		[Description("Hourly")]
		Hourly,

		[Description("Daily")]
		Daily,

		[Description("Weekly")]
		Weekly,

		[Description("Monthly")]
		Monthly,

		[Description("Yearly")]
		Yearly
	}
}
