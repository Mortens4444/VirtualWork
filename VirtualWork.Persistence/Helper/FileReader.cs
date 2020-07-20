using System.IO;
using System.Reflection;

namespace VirtualWork.Persistence.Helper
{
	public static class FileReader
	{
		public static string GetEmbeddedFileContent(string resourceName)
		{
			var assembly = Assembly.GetExecutingAssembly();
			using (var stream = assembly.GetManifestResourceStream(resourceName))
			{
				using (var reader = new StreamReader(stream))
				{
					return reader.ReadToEnd();
				}
			}
		}
	}
}
