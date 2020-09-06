using System;
using System.Threading;
using System.Threading.Tasks;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;

namespace VirtualWork.Service
{
	public class ActiveSleepNotifier
	{
		public async void NotifyAt(AppointmentBase appointment, Action action, CancellationToken cancellationToken)
		{
			await Task.Factory.StartNew(() =>
			{
				var targetDateTime = appointment.AppointmentDate;

				// Fast forward on past occurrences.
				while (targetDateTime < DateTime.Now)
				{
					targetDateTime = targetDateTime.CalculateNextOccurrence(appointment.RepetitionType, appointment.RepetitionValue, appointment.ExpirationDate);
				}

				while (targetDateTime != DateTime.MaxValue)
				{
					// Waiting for next occurrence.
					while (DateTime.Now < targetDateTime && !cancellationToken.IsCancellationRequested)
					{
						Thread.Sleep(100);
					}
					if (cancellationToken.IsCancellationRequested)
					{
						targetDateTime = DateTime.MaxValue;
						break;
					}
					else
					{
						action();

						// Get next occurrence.
						while (targetDateTime < DateTime.Now)
						{
							targetDateTime = targetDateTime.CalculateNextOccurrence(appointment.RepetitionType, appointment.RepetitionValue, appointment.ExpirationDate);
						}
					}
				}
			}, cancellationToken);
		}
	}
}
