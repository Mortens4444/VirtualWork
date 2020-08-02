using System;
using SourceInfo;
using VirtualWork.Core.Log;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Log;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.Service.Log
{
	public class DatabaseLogger : ILogger
	{
		private readonly LogEntryRepository logEntryRepository;

		public DatabaseLogger(LogEntryRepository logEntryRepository)
		{
			this.logEntryRepository = logEntryRepository;
		}

		public void Debug(string logInfo)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Debug);
			logEntryRepository.Add(logEntry);
		}

		public void Error(string logInfo)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Error);
			logEntryRepository.Add(logEntry);
		}

		public void Error(Exception exception)
		{
			Error(exception.GetDetails());
		}

		public void Info(string logInfo)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Info);
			logEntryRepository.Add(logEntry);
		}

		public void Warning(string logInfo)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Warning);
			logEntryRepository.Add(logEntry);
		}

		private static LogEntry GetLogEntry(string logInfo, LogLevel logLevel)
		{
			return new LogEntry
			{
				LogLevel = logLevel,
				Message = logInfo,
				//User = user
			};
		}
	}
}
