using System.ComponentModel;

namespace VirtualWork.Interfaces.Enums
{
	public enum CalendarViewType
	{
		Today,

		[Description("This week")]
		ThisWeek,

		[Description("This month")]
		ThisMonth
	}
}
