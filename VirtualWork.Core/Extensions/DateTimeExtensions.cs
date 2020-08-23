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

		public static bool IsOnSameDate(this DateTime baseDateTime, DateTime testedDateTime)
		{
			return baseDateTime.Year == testedDateTime.Year && baseDateTime.Month == testedDateTime.Month && baseDateTime.Day == testedDateTime.Day;
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
				switch (repetitionType)
				{
					case RepetitionType.EveryMillisecond:
						actualDateTime = actualDateTime.AddMilliseconds(repetitionValue);
						break;
					case RepetitionType.EverySecond:
						actualDateTime = actualDateTime.AddSeconds(repetitionValue);
						break;
					case RepetitionType.EveryMinute:
						actualDateTime = actualDateTime.AddMinutes(repetitionValue);
						break;
					case RepetitionType.Hourly:
						actualDateTime = actualDateTime.AddHours(repetitionValue);
						break;
					case RepetitionType.Daily:
						actualDateTime = actualDateTime.AddDays(repetitionValue);
						break;
					case RepetitionType.Weekly:
						actualDateTime = actualDateTime.AddDays(7 * repetitionValue);
						break;
					case RepetitionType.Monthly:
						actualDateTime = actualDateTime.AddMonths(repetitionValue);
						break;
					case RepetitionType.Yearly:
						actualDateTime = actualDateTime.AddYears(repetitionValue);
						break;
					default:
						throw new NotImplementedException($"Repetition type not found: {repetitionType}");
				}

				if (actualDateTime.IsOnSameDate(testedDateTime))
				{
					return true;
				}
			}
			return false;
		}
	}
}
