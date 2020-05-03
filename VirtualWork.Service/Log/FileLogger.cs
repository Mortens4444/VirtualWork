using System;
using System.IO;
using VirtualWork.Core.Directories;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Service.Log
{
	class FileLogger : ILogger
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
			#if DEBUG
				WriteToLogFile(logMessage, LogLevel.DEBUG);
			#endif
		}

		public void Error(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.ERROR);
		}

		public void Info(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.INFO);
		}

		public void Warning(string logMessage)
		{
			WriteToLogFile(logMessage, LogLevel.WARNING);
		}

		private void WriteToLogFile(string text, LogLevel logLevel = LogLevel.INFO)
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
