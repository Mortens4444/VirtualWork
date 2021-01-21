using System.Windows.Forms;

namespace VirtualWork.WinForms.Extensions
{
	public static class MonthCalendarExtensions
	{
		public static void RefreshView(this MonthCalendar monthCalendar)
		{
			monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddYears(-1);
			monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddYears(1);
		}
	}
}
