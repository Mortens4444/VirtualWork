using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Dto;
using VirtualWork.WinForms.Extensions;
using static System.Windows.Forms.ListViewItem;

namespace VirtualWork.WinForms.Providers
{
	public class FileAndFolderProvider
	{
		private readonly IEnumerable<string> rootDrectories;
		public const string ParentDirectory = "..";

		public FileAndFolderProvider()
		{
			rootDrectories = DriveInfo.GetDrives().Select(drive => drive.RootDirectory.Name);
		}

		public ListViewItemsResult Get(string workingDirectory)
		{
			var result = new ListViewItemsResult();
			var items = new List<ListViewItem>();

			try
			{
				if (rootDrectories.All(rootDirectory => rootDirectory != workingDirectory))
				{
					items.Add(new ListViewItem
					{
						ImageIndex = 4,
						Text = ParentDirectory
					});
				}

				var directories = Directory.GetDirectories(workingDirectory);
				var directoryListViewItems = directories.Select(
					directory => new ListViewItem
					{
						ImageIndex = 4,
						Text = Path.GetFileName(directory)
					});
				items.AddRange(directoryListViewItems.ToArray());

				var files = Directory.GetFiles(workingDirectory);
				var fileListViewItems = new List<ListViewItem>();
				foreach (var file in files)
				{
					var listViewItem = new ListViewItem
					{
						ImageIndex = GetImageIndex(file),
						Text = Path.GetFileName(file)
					};
					var fileInfo = new FileInfo(file);
					listViewItem.SubItems.Add(new ListViewSubItem(listViewItem, fileInfo.Length.GetHumanReadableSize()));
					fileListViewItems.Add(listViewItem);
				}
				items.AddRange(fileListViewItems.ToArray());
				result.Success = true;
				result.Items = items.ToArray();
			}
			catch (Exception ex)
			{
				ErrorBoxHelper.Show(ex);
			}

			return result;
		}

		private int GetImageIndex(string filename)
		{
			var extensionWithDot = Path.GetExtension(filename);
			if (!String.IsNullOrEmpty(extensionWithDot))
			{
				var extension = extensionWithDot.Substring(1).ToUpper();
				switch (extension)
				{
					case "MDB":
						return 6;
					case "CSV":
						return 7;
					case "XLS":
					case "XLSX":
						return 8;
					case "AVI":
					case "MOV":
					case "MPG":
					case "MPEG":
					case "MKV":
						return 9;
					case "MP3":
						return 10;
					case "PDF":
						return 11;
					case "CPP":
						return 12;
					case "CS":
						return 13;
					case "PHP":
						return 14;
					case "TXT":
						return 15;
					case "RTF":
					case "DOC":
					case "DOCX":
						return 16;
					case "URL":
						return 17;
					case "XML":
						return 18;
					case "EXE":
						return 19;
					case "COM":
						return 20;
					case "CSS":
						return 21;
					case "HTML":
						return 22;
					case "REG":
						return 23;
					case "JS":
					case "TS":
						return 24;
					case "MSI":
						return 25;
					case "WAV":
					case "OGG":
						return 26;
					case "BMP":
					case "JPG":
					case "JPEG":
					case "PNG":
					case "GIF":
					case "JPE":
					case "TGA":
					case "SVG":
						return 27;
					case "ARJ":
					case "RAR":
					case "ZIP":
					case "7Z":
					case "GZ":
					case "TAR":
						return 28;
					case "CUR":
						return 29;
					case "HLP":
						return 30;
				}

			}
			return 5;
		}
	}
}
