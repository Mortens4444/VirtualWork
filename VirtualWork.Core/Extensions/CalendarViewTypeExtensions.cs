using System;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Extensions
{
	public static class CalendarViewTypeExtensions
	{
		public static int GetNumberOfDays(this CalendarViewType calendarViewType, DateTime dateTime)
		{
			switch (calendarViewType)
			{
				case CalendarViewType.Today:
					return 1;
				case CalendarViewType.ThisWeek:
					return 7;
				case CalendarViewType.ThisMonth:
					return DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
			}

			throw new NotImplementedException();
		}
	}
}
