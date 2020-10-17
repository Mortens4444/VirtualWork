using System;

namespace VirtualWork.Interfaces.Exceptions
{
	public class ExceptionOccurredEventArgs : EventArgs
	{
		public Exception Exception { get; }

		public ExceptionOccurredEventArgs(Exception exception)
		{
			Exception = exception;
		}
	}
}
