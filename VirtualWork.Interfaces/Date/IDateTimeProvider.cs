using System;

namespace VirtualWork.Interfaces.Date
{
	public interface IDateTimeProvider
	{
		TimeSpan RefreshInterval { get; set; }

		event EventHandler<ActualDateTimeReportEventArgs> ActualDateTimeReport;
	}
}