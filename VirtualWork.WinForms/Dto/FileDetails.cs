using System.IO;

namespace VirtualWork.WinForms.Dto
{
	public class FileDetails
	{
		public string FileName { get; private set; }

		public string ShowFileName { get; private set; }

		public bool Changed { get; set; }

		public FileDetails(string fileName)
		{
			FileName = fileName;
			ShowFileName = Path.GetFileName(fileName);
		}
	}
}
