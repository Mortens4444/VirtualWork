using System;
using System.Threading;
using System.Threading.Tasks;
using VirtualWork.Core.Appointment;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Service
{
	public class ActiveSleepNotifier
	{
		private readonly ILogger logger;

		public ActiveSleepNotifier(ILogger logger)
		{
			this.logger = logger;
		}

		public async void NotifyAt(AppointmentBase appointment, Action action, CancellationToken cancellationToken)
		{
			try
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
			catch (TaskCanceledException ex)
			{
				logger.Warning(ex);
			}
		}
	}
}
