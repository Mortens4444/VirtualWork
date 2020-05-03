using System.IO;

namespace VirtualWork.Core.Directories
{
	public static class DirectoryUtils
	{
		public static void CreateDirectoryIfNotExists(string directory)
		{
			if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}
		}
	}
}
