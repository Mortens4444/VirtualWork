using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using VirtualWork.Service.Utils;

namespace VirtualWork.Service.Process
{
	public static class ProcessUtils
	{
		private const string NotepadPlusPlus = @"C:\Program Files\Notepad++\notepad++.exe";

		public static void OpenInBrowser(string link)
		{
			try
			{
				System.Diagnostics.Process.Start(link);
			}
			catch (Exception ex)
			{
				ErrorBoxHelper.Show(ex);
			}
		}

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
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1155)
				{
					var editor = File.Exists(NotepadPlusPlus) ? NotepadPlusPlus : "notepad";
					Start(editor, process);
				}
				else
				{
					ErrorBoxHelper.Show(ex);
				}
			}
			catch (Exception ex)
			{
				ErrorBoxHelper.Show(ex);
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
				ErrorBoxHelper.Show(ex);
			}
		}
	}
}
