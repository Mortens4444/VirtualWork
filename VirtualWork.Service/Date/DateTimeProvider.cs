using System;
using System.ComponentModel;
using System.Threading;
using LanguageService;
using VirtualWork.Core.Extensions;
using VirtualWork.Interfaces.Date;

namespace VirtualWork.Service.Date
{
	public class DateTimeProvider : IDateTimeProvider
	{
		public event EventHandler<ActualDateTimeReportEventArgs> ActualDateTimeReport;

		/// <summary>
		/// Refreshing interval in milliseconds.
		/// </summary>
		public TimeSpan RefreshInterval { get; set; } = TimeSpan.FromMilliseconds(500);

		public DateTimeProvider()
		{
			var backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.RunWorkerAsync();
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			while (true)
			{
				var now = DateTime.Now;

				var dateTimeString = $"{now.ToShortDateString()} {now.ToLongTimeString()} ({Lng.Elem("Week of the year")}: {now.GetWeekNumber()})";
				OnMyEvent(this, new ActualDateTimeReportEventArgs(dateTimeString));
				Thread.Sleep(RefreshInterval);
			}
		}

		protected virtual void OnMyEvent(DateTimeProvider sender, ActualDateTimeReportEventArgs e)
		{
			var handler = ActualDateTimeReport;
			handler?.Invoke(sender, e);
		}
	}
}
