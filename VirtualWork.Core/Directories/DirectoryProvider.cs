using System;
using System.IO;

namespace VirtualWork.Core.Directories
{
	public static class DirectoryProvider
	{
		public static string ApplicationFolder => AppDomain.CurrentDomain.BaseDirectory;

		public static string DocumentaionFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documentation");
	}
}
