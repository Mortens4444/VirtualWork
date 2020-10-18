using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using VirtualWork.Service.Utils;

namespace VirtualWork.Service.Process
{
	public class ProcessUtils
	{
		private const string NotepadPlusPlus = @"C:\Program Files\Notepad++\notepad++.exe";

		private readonly ErrorBoxHelper errorBoxHelper;

		public ProcessUtils(ErrorBoxHelper errorBoxHelper)
		{
			this.errorBoxHelper = errorBoxHelper;
		}

		public void OpenInBrowser(string link)
		{
			try
			{
				System.Diagnostics.Process.Start(link);
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		public void Start(string process, string arguments = null)
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
					errorBoxHelper.Show(ex);
				}
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}

		public System.Diagnostics.Process StartWithRedirect(string process, string arguments = null)
		{
			try
			{
				return System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = process,
					Arguments = arguments,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					UseShellExecute = false,
					CreateNoWindow = true
				});
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
				return null;
			}
		}

		public void StartAsAdmin(string process, string arguments = null)
		{
			try
			{
				System.Diagnostics.Process.Start(new ProcessStartInfo
				{
					FileName = process,
					Arguments = arguments,
					Verb = "RunAs"
				});
			}
			catch (Exception ex)
			{
				errorBoxHelper.Show(ex);
			}
		}
	}
}
