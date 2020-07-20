using System;
using System.Globalization;

namespace VirtualWork.Core.Extensions
{
	public static class DateTimeExtensions
	{
		public static int GetWeekNumber(this DateTime dateTime)
		{
			return GetWeekNumber(dateTime, CultureInfo.CurrentCulture);
		}

		public static int GetWeekNumber(this DateTime dateTime, CultureInfo cultureInfo)
		{
			return cultureInfo.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
		}
	}
}
