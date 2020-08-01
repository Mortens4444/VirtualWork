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

		public static DateTime GetRepositoryDateTimeFormat(this DateTime dateTime)
		{
			return dateTime.ToUniversalTime();
		}

		public static DateTime GetViewDateTimeFormat(this DateTime dateTime)
		{
			return dateTime.ToLocalTime();
		}

		public static bool IsDateTimeBetweenTimeSpans(this DateTime dateTime, TimeSpan first, TimeSpan second)
		{
			var time = new TimeSpan(dateTime.Hour, dateTime.Minute, dateTime.Second);
			return time >= first && time < second;
		}

		public static bool IsDateTimeTheSameAs(this DateTime dateTime, DateTime other)
		{
			return dateTime.Year == other.Year && dateTime.Month == other.Month && dateTime.Day == other.Day;
		}
	}
}
