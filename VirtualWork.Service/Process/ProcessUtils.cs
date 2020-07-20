using System;
using System.Diagnostics;
using MessageBoxes;

namespace VirtualWork.Service.Process
{
	public static class ProcessUtils
	{
		public static void Start(string process, string arguments = null)
		{
			try
			{
				System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					FileName = process,
					Arguments = arguments
				});
			}
			catch (Exception ex)
			{
				ErrorBox.Show(ex);
			}
		}

		public static void StartAsAdmin(string process, string arguments = null)
		{
			try
			{
				System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					FileName = process,
					Arguments = arguments,
					Verb = "runas"
				});
			}
			catch (Exception ex)
			{
				ErrorBox.Show(ex);
			}
		}
	}
}
