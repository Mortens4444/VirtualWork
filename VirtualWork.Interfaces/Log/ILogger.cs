using System;

namespace VirtualWork.Interfaces.Log
{
	public interface ILogger
	{
		void Info(string logInfo);

		void Warning(string logInfo);

		void Error(string logInfo);

		void Error(Exception exception);

		void Debug(string logInfo);
	}
}
