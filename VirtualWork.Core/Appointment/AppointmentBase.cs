using System;
using System.Collections.Generic;
using VirtualWork.Interfaces;
using VirtualWork.Interfaces.Enums;

namespace VirtualWork.Core.Appointment
{
	public abstract class AppointmentBase : IHaveIdentifier, IHaveTitle
	{
		private const int MaximumNumberOfDates = 1000;

		private static readonly Dictionary<RepetitionType, ModifyDateDelegate> DateModifiers = new Dictionary<RepetitionType, ModifyDateDelegate>
		{
			{ RepetitionType.NoRepeat, null },
			{ RepetitionType.EveryMillisecond, (dateTime, addition) => dateTime.AddDays(addition) },
			{ RepetitionType.EverySecond, (dateTime, addition) => dateTime.AddDays(addition) },
			{ RepetitionType.EveryMinute, (dateTime, addition) => dateTime.AddDays(addition) },
			{ RepetitionType.Hourly, (dateTime, addition) => dateTime.AddDays(addition) },
			{ RepetitionType.Daily, (dateTime, addition) => dateTime.AddDays(addition) },
			{ RepetitionType.Weekly, (dateTime, addition) => dateTime.AddDays(7 * addition) },
			{ RepetitionType.Monthly, (dateTime, addition) => dateTime.AddMonths(addition) },
			{ RepetitionType.Yearly, (dateTime, addition) => dateTime.AddYears(addition) }
		};

		private delegate DateTime ModifyDateDelegate(DateTime dateTime, int addition);

		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public abstract DateTime AppointmentDate { get; }

		public abstract DateTime AppointmentEndDate { get; }

		public DateTime? ExpirationDate { get; set; }

		public int RepetitionValue { get; set; }

		public RepetitionType RepetitionType { get; set; }

		public override string ToString()
		{
			if (String.IsNullOrEmpty(Description))
			{
				if (String.IsNullOrEmpty(Title))
				{
					return $"{AppointmentDate.ToShortDateString()} {AppointmentDate.ToShortTimeString()}";
				}
				return Title;
			}

			if (String.IsNullOrEmpty(Title))
			{
				return Description;
			}
			return $"{Title} - {Description}";
		}

		public DateTime? GetNextOccurenceAfterDate(DateTime date)
		{
			var actualDate = AppointmentDate;
			var expirationDate = ExpirationDate ?? DateTime.Now.AddYears(3);
			var functionDelegate = DateModifiers[RepetitionType];

			if (expirationDate >= DateTime.Now && functionDelegate != null)
			{
				int index = 0;
				while (actualDate < expirationDate && index < MaximumNumberOfDates)
				{
					if (actualDate > date)
					{
						break;
					}
					actualDate = functionDelegate(actualDate, RepetitionValue);
					index++;
				}
			}
			if (actualDate > date)
			{
				return actualDate;
			}

			return null;
		}

		public IList<DateTime> GetNextOccuranceDates()
		{
			var result = new List<DateTime>();
			var actualDate = AppointmentDate;
			var expirationDate = ExpirationDate ?? DateTime.Now.AddYears(3);
			var functionDelegate = DateModifiers[RepetitionType];
			if (expirationDate >= DateTime.Now)
			{
				if (functionDelegate == null)
				{
					if (actualDate >= DateTime.Now)
					{
						result.Add(actualDate);
					}
				}
				else
				{
					while (actualDate < expirationDate && result.Count < MaximumNumberOfDates)
					{
						actualDate = functionDelegate(actualDate, RepetitionValue);
						result.Add(actualDate);
					}
				}
			}
			return result;
		}
	}
}
