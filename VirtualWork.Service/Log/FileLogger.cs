using System;
using System.IO;
using SourceInfo;
using VirtualWork.Core.Directories;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Service.Log
{
	public class FileLogger : ILogger
	{
		private readonly string LogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"VIRtualWork\Log.txt");

		public FileLogger()
		{
			DirectoryUtils.CreateDirectoryIfNotExists(Path.GetDirectoryName(LogFile));
			if (!File.Exists(LogFile))
			{
				WriteToLogFile("Log file has been created");
			}
		}

		public void Debug(string logMessage, IUser user = null)
		{
			WriteToLogFile(logMessage, user, LogLevel.Debug);
		}

		public void Error(string logMessage, IUser user = null)
		{
			WriteToLogFile(logMessage, user, LogLevel.Error);
		}

		public void Error(Exception exception, IUser user = null)
		{
			Error(exception.GetDetails(), user);
		}

		public void Info(string logMessage, IUser user = null)
		{
			WriteToLogFile(logMessage, user, LogLevel.Info);
		}

		public void Warning(string logMessage, IUser user = null)
		{
			WriteToLogFile(logMessage, user, LogLevel.Warning);
		}

		public void Warning(Exception exception, IUser user = null)
		{
			Warning(exception.GetDetails(), user);
		}

		private void WriteToLogFile(string text, IUser user = null, LogLevel logLevel = LogLevel.Info)
		{
			var logMessage = ComposeLogMessage(text, logLevel);
			using (var streamWriter = File.AppendText(LogFile))
			{
				var executor = user?.Name ?? String.Empty;
				executor = executor != String.Empty ? $"{executor}: " : executor;
				streamWriter.WriteLine($"{executor} {logMessage}");
				streamWriter.Flush();
			}
		}

		private string ComposeLogMessage(string message, LogLevel logLevel)
		{
			return $"{DateTime.UtcNow}: {logLevel} - {message}";
		}
	}
}
