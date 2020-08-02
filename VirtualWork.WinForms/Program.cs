using System;
using System.Windows.Forms;
using LanguageService;
using MessageBoxes;
using Ninject;
using VirtualWork.Core.Exceptions;

namespace VirtualWork.WinForms
{
	static class Program
	{
		private static readonly IKernel kernel = KernelProvider.Get();
		private static readonly ExceptionCatcher exceptionCatcher = kernel.Get<ExceptionCatcher>();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BaseBox.OK = Lng.Elem("OK");
			BaseBox.Yes = Lng.Elem("Yes");
			BaseBox.No = Lng.Elem("No");
			BaseBox.EnableAutomaticMessageClosing = Lng.Elem("Enable automatic message closing");
			BaseBox.DisableAutomaticMessageClosing = Lng.Elem("Disable automatic message closing");
			BaseBox.Cancel = Lng.Elem("Cancel");
			BaseBox.CopyToClipboard = Lng.Elem("Copy to clipboard");

			var initializer = kernel.Get<Initializer>();
			initializer.CreateDefaultInstancesAndLogin();
		}
	}
}
