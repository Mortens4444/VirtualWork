using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using VirtualWork.Core.Directories;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Core.Exceptions
{
	public class ExceptionCatcher
	{
		private readonly ILogger logger;

		public ExceptionCatcher(ILogger logger)
		{
			this.logger = logger;
			var currentDomain = AppDomain.CurrentDomain;
			currentDomain.UnhandledException += UnhandledExceptionHandler;
		}

		private void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
		{
			var ex = e.ExceptionObject as Exception;
			logger.Error(ex);
			ShowUnhandledException(ex);
			Environment.Exit(-1);
		}

		private static void ShowUnhandledException(Exception ex)
		{
			var message = String.Concat(ex.Message, " ", ex.StackTrace);
			var title = ex.GetType().ToString();
			Process.Start(new ProcessStartInfo
			{
				FileName = Path.Combine(DirectoryProvider.ApplicationFolder, "MessageBoxSender.exe"),
				Arguments = $"-m \"{message}\" -t \"{title}\" -e"
			});
		}
	}
}
