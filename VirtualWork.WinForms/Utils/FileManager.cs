using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Enums;
using LanguageService;
using MessageBoxes;
using VirtualWork.Service.Process;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Extensions;
using VirtualWork.WinForms.Providers;

namespace VirtualWork.WinForms.Utils
{
	public class FileManager
	{
		private string workingDirectoryOnLeft;
		private string workingDirectoryOnRight;

		public ListView Active { get; set; }
		public string WorkingDirectoryOnLeft { get => workingDirectoryOnLeft; }
		public string WorkingDirectoryOnRight { get => workingDirectoryOnRight; }

		private readonly FileAndFolderProvider fileAndFolderProvider;
		private readonly ProcessUtils processUtils;
		private readonly ErrorBoxHelper errorBoxHelper;

		public FileManager(FileAndFolderProvider fileAndFolderProvider,
			ProcessUtils processUtils,
			ErrorBoxHelper errorBoxHelper)
		{
			this.fileAndFolderProvider = fileAndFolderProvider;
			this.processUtils = processUtils;
			this.errorBoxHelper = errorBoxHelper;

			workingDirectoryOnLeft = (DriveInfo.GetDrives())[0].Name;
			workingDirectoryOnRight = WorkingDirectoryOnLeft;
		}

		public string ListDriveOnTheLeft(ComboBox comboBox, ListView listView)
		{
			return ListDrive(comboBox, listView, ref workingDirectoryOnLeft);
		}

		public string ListDriveOnTheRight(ComboBox comboBox, ListView listView)
		{
			return ListDrive(comboBox, listView, ref workingDirectoryOnRight);
		}

		private string ListDrive(ComboBox comboBox, ListView listView, ref string workingDirectory)
		{
			var filesAndFolders = fileAndFolderProvider.Get(comboBox.Text);
			if (filesAndFolders.Success)
			{
				listView.FillItems(filesAndFolders.Items);
				workingDirectory = comboBox.Text;
			}
			if (listView == Active)
			{
				return workingDirectory;
			}

			return null;
		}

		public void Copy(ListView lvFileExplorerLeft, ListView lvFileExplorerRight)
		{
			var source = Active == lvFileExplorerLeft ? WorkingDirectoryOnLeft : WorkingDirectoryOnRight;
			var destination = Active == lvFileExplorerLeft ? WorkingDirectoryOnRight : WorkingDirectoryOnLeft;

			foreach (ListViewItem item in Active.SelectedItems)
			{
				if (item.Text == FileAndFolderProvider.ParentDirectory)
				{
					continue;
				}

				var sourceFile = Path.Combine(source, item.Text);
				var destinationFile = Path.Combine(destination, item.Text);

				DialogResult dialogResult;
				if (File.Exists(destinationFile))
				{
					dialogResult = ConfirmBox.Show(Lng.Elem("Confirmation"),
						String.Concat(Lng.Elem("Are you sure you want to overwrite this file?"), Environment.NewLine, destinationFile), Decide.No);
				}
				else
				{
					dialogResult = DialogResult.Yes;
				}

				try
				{
					File.Copy(sourceFile, destinationFile, dialogResult == DialogResult.Yes);
					if (Active == lvFileExplorerLeft)
					{
						ListFiles(lvFileExplorerLeft, ref workingDirectoryOnLeft);
					}
					else
					{
						ListFiles(lvFileExplorerRight, ref workingDirectoryOnRight);
					}
				}
				catch (Exception ex)
				{
					errorBoxHelper.Show(ex);
				}
			}
		}

		public string ListFilesOnTheLeft(ListView listView)
		{
			return ListFiles(listView, ref workingDirectoryOnLeft);
		}

		public string ListFilesOnTheRight(ListView listView)
		{
			return ListFiles(listView, ref workingDirectoryOnRight);
		}

		private string ListFiles(ListView listView, ref string workingDirectory)
		{
			if (listView.SelectedItems.Count == 1)
			{
				var navigateToParent = listView.SelectedItems[0].Text == FileAndFolderProvider.ParentDirectory;
				var fullPath = navigateToParent ? Directory.GetParent(workingDirectory).FullName :
					Path.Combine(workingDirectory, listView.SelectedItems[0].Text);

				if (File.Exists(fullPath))
				{
					var mediaFileExtensions = new List<string> { ".avi", ".mp3", ".mpg", ".ogg", ".wav" };
					if (mediaFileExtensions.Contains(Path.GetExtension(fullPath).ToLower()))
					{
						PlayMediaFile(fullPath);
					}
					else
					{
						processUtils.Start(fullPath);
					}
				}
				else if (Directory.Exists(fullPath))
				{
					var filesAndFolders = fileAndFolderProvider.Get(fullPath);
					if (filesAndFolders.Success)
					{
						listView.FillItems(filesAndFolders.Items, navigateToParent ? workingDirectory : null);
						workingDirectory = fullPath;
					}
				}
			}
			if (listView == Active)
			{
				return workingDirectory;
			}

			return null;
		}

		private void PlayMediaFile(string filePath)
		{
			if (!Directory.Exists(filePath))
			{
				var mediaPlayer = new MediaPlayer(filePath);
				mediaPlayer.Play(false);
				mediaPlayer.PlayStopped += (_, __) =>
				{
				};
			}
		}
	}
}
