using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using MessageBoxes;

namespace VirtualWork.Service.Process
{
	public static class ProcessUtils
	{
		private const string NotepadPlusPlus = @"C:\Program Files\Notepad++\notepad++.exe";

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
					ErrorBox.Show(ex);
				}
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
