using System;
using SourceInfo;
using VirtualWork.Core.Log;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Log;
using LogEntryRepository = VirtualWork.Persistence.Repositories.RepositoryBase<VirtualWork.Core.Log.LogEntry, VirtualWork.Persistence.Entities.LogEntry>;

namespace VirtualWork.Service.Log
{
	public class DatabaseLogger : ILogger
	{
		private readonly LogEntryRepository logEntryRepository;

		public DatabaseLogger(LogEntryRepository logEntryRepository)
		{
			this.logEntryRepository = logEntryRepository;
		}

		public void Debug(string logInfo, IUser user = null)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Debug, user);
			logEntryRepository.Add(logEntry);
		}

		public void Error(string logInfo, IUser user = null)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Error, user);
			logEntryRepository.Add(logEntry);
		}

		public void Error(Exception exception, IUser user = null)
		{
			Error(exception.GetDetails(), user);
		}

		public void Info(string logInfo, IUser user = null)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Info, user);
			logEntryRepository.Add(logEntry);
		}

		public void Warning(string logInfo, IUser user = null)
		{
			var logEntry = GetLogEntry(logInfo, LogLevel.Warning, user);
			logEntryRepository.Add(logEntry);
		}

		private static LogEntry GetLogEntry(string logInfo, LogLevel logLevel, IUser user)
		{
			return new LogEntry
			{
				TimeStamp = DateTime.Now,
				LogLevel = logLevel,
				Message = logInfo,
				User = user
			};
		}
	}
}
