using System;
using System.IO;
using SourceInfo;
using VirtualWork.Core.Directories;
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

		public void Debug(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.Debug);
		}

		public void Error(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.Error);
		}

		public void Error(Exception exception)
		{
			Error(exception.GetDetails());
		}

		public void Info(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.Info);
		}

		public void Warning(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.Warning);
		}

		private void WriteToLogFile(string text, LogLevel logLevel = LogLevel.Info)
		{
			var logMessage = ComposeLogMessage(text, logLevel);
			using (var streamWriter = File.AppendText(LogFile))
			{
				streamWriter.WriteLine(logMessage);
				streamWriter.Flush();
			}
		}

		private string ComposeLogMessage(string message, LogLevel logLevel)
		{
			return $"{DateTime.UtcNow}: {logLevel} - {message}";
		}
	}
}
