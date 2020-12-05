using System;
using System.Globalization;
using VirtualWork.Interfaces.Enums;

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

		public static bool AreDatesTimeBetweenTimeSpans(DateTime startDateTime, DateTime endDateTime, TimeSpan first, TimeSpan second)
		{
			if (startDateTime.Date == endDateTime.Date)
			{
				return IsDateTimeBetweenTimeSpans(startDateTime, first, second);
			}
			var startTime = new TimeSpan(startDateTime.Hour, startDateTime.Minute, startDateTime.Second);
			var endTime = new TimeSpan(endDateTime.Hour, endDateTime.Minute, endDateTime.Second);
			return startTime <= first && endTime >= second;
		}

		public static bool IsOnSameDate(this DateTime baseDateTime, DateTime testedDateTime)
		{
			return baseDateTime.Year == testedDateTime.Year && baseDateTime.Month == testedDateTime.Month && baseDateTime.Day == testedDateTime.Day;
		}

		public static DateTime CalculateNextOccurrence(this DateTime baseDateTime, RepetitionType repetitionType, int repetitionValue, DateTime? expirationDate)
		{
			DateTime result;
			switch (repetitionType)
			{
				case RepetitionType.NoRepeat:
					result = DateTime.MaxValue;
					break;
				case RepetitionType.EveryMillisecond:
					result = baseDateTime.AddMilliseconds(repetitionValue);
					break;
				case RepetitionType.EverySecond:
					result = baseDateTime.AddSeconds(repetitionValue);
					break;
				case RepetitionType.EveryMinute:
					result = baseDateTime.AddMinutes(repetitionValue);
					break;
				case RepetitionType.Hourly:
					result = baseDateTime.AddHours(repetitionValue);
					break;
				case RepetitionType.Daily:
					result = baseDateTime.AddDays(repetitionValue);
					break;
				case RepetitionType.Weekly:
					result = baseDateTime.AddDays(7 * repetitionValue);
					break;
				case RepetitionType.Monthly:
					result = baseDateTime.AddMonths(repetitionValue);
					break;
				case RepetitionType.Yearly:
					result = baseDateTime.AddYears(repetitionValue);
					break;
				default:
					throw new NotImplementedException($"Repetition type not found: {repetitionType}");
			}
			return !expirationDate.HasValue || result < expirationDate ? result : DateTime.MaxValue;
		}

		public static bool IsRepeatedOnDate(this DateTime firstOccurrence, DateTime testedDateTime, RepetitionType repetitionType, int repetitionValue, DateTime? expirationDate)
		{
			if (firstOccurrence.IsOnSameDate(testedDateTime))
			{
				return true;
			}
			else
			{
				if (repetitionType == RepetitionType.NoRepeat)
				{
					return false;
				}
			}

			if (expirationDate == null)
			{
				expirationDate = DateTime.Now.AddYears(3);
			}

			var actualDateTime = firstOccurrence;
			while (actualDateTime < expirationDate)
			{
				actualDateTime = actualDateTime.CalculateNextOccurrence(repetitionType, repetitionValue, expirationDate);
				if (actualDateTime.IsOnSameDate(testedDateTime))
				{
					return true;
				}

				if (actualDateTime > testedDateTime)
				{
					break;
				}
			}
			return false;
		}

		public static DateTime CutMinutes(this DateTime dateTime)
		{
			return dateTime.AddMinutes(-dateTime.Minute);
		}

		public static DateTime CutSeconds(this DateTime dateTime)
		{
			return dateTime.AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);
		}

		public static DateTime GetStartOfTheWeek(this DateTime dateTime)
		{
			return dateTime.AddDays(dateTime.DayOfWeek == DayOfWeek.Sunday ? -6 : -(int)dateTime.DayOfWeek + 1).Date;
		}

		public static DateTime GetStartDate(this DateTime dateTime, CalendarViewType calendarViewType)
		{
			switch (calendarViewType)
			{
				case CalendarViewType.Today:
					return dateTime;
				case CalendarViewType.ThisWeek:
					return dateTime.GetStartOfTheWeek();
				case CalendarViewType.ThisMonth:
					return new DateTime(dateTime.Year, dateTime.Month, 1);
			}

			throw new NotImplementedException();
		}
	}
}
