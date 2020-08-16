using System.IO;

namespace VirtualWork.Service.FileHandling
{
	public class FileWriter
	{
		public void CreateOrOverwriteFile(string filePath, string content)
		{
			using (var streamWriter = File.CreateText(filePath))
			{
				streamWriter.Write(content);
				streamWriter.Close();
			}
		}
	}
}
