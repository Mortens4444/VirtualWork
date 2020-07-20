using System;

namespace VirtualWork.Interfaces.Date
{
	public class ActualDateTimeReportEventArgs : EventArgs
	{
		public string DateTimeString { get; }

		public ActualDateTimeReportEventArgs(string dateTimeString)
		{
			DateTimeString = dateTimeString;
		}
	}
}
