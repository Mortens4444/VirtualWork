using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Service.FileHandling;
using VirtualWork.Service.Utils;
using VirtualWork.WinForms.Controls;
using VirtualWork.WinForms.Dto;
using VirtualWork.WinForms.Factories;

namespace VirtualWork.WinForms
{
	public partial class EditorForm : Form
	{
		private readonly FileReader fileReader;
		private readonly FileTabPageFactory fileTabPageFactory;
		private readonly ClipboardHelper clipboardHelper;
		//private readonly OptionsHandler optionsHandler;
		//private readonly OptionsDto options;

		public EditorForm(FileReader fileReader,
			FileTabPageFactory fileTabPageFactory,
			ClipboardHelper clipboardHelper
			/*OptionsHandler optionsHandler*/)
		{
			this.clipboardHelper = clipboardHelper;
			this.fileReader = fileReader;
			this.fileTabPageFactory = fileTabPageFactory;

			InitializeComponent();
			if (components == null)
			{
				components = new Container();
			}

			Translator.Translate(this);
		}

		public void Show(string fileName = null)
		{
			if (fileName != null)
			{
				OpenFile(fileName);
			}
			base.Show();
		}

		private void OpenNewTab(FileDetails fileDetails)
		{
			var menuItems = new ToolStripItem[]
			{
				/*copyPathMenuItem,
				toolStripSeparator3,
				closeMenuItem,
				closeAllButThisMenuItem,
				closeAllMenuItem*/
			};
			var newTab = fileTabPageFactory.Create(fileDetails, components, menuItems);
			tabControl.Controls.Add(newTab);
			tabControl.SelectedTab = newTab;
		}

		private void CopyPathMenuItem_Click(object sender, EventArgs e)
		{
			if (((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl is FileRichTextBox fileRichTextBox && fileRichTextBox.FileDetails != null)
			{
				clipboardHelper.SetText(fileRichTextBox.FileDetails.FileName);
			}
		}

		private void NewMenuItem_Click(object sender, EventArgs e)
		{
			OpenNewTab(null);
		}

		private void CutMenuItem_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^X");
		}

		private void CopyMenuItem_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^C");
		}

		private void PasteMenuItem_Click(object sender, EventArgs e)
		{
			SendKeys.Send("^V");
		}

		private void CloseMenuItemFM_Click(object sender, EventArgs e)
		{
			var fileTabPage = tabControl.SelectedTab as FileTabPage;
			CloseTabPage(fileTabPage);
		}

		private void CloseAllButThisMenuItemFM_Click(object sender, EventArgs e)
		{
			var selectedTabPage = tabControl.SelectedTab as FileTabPage;
			foreach (FileTabPage tabPage in tabControl.TabPages)
			{
				if (tabPage != selectedTabPage)
				{
					CloseTabPage(tabPage);
				}
			}
		}

		private void CloseAllMenuItemFM_Click(object sender, EventArgs e)
		{
			foreach (FileTabPage tabPage in tabControl.TabPages)
			{
				CloseTabPage(tabPage);
			}
		}

		private void CloseTabPage(FileTabPage fileTabPage)
		{
			tabControl.TabPages.Remove(fileTabPage);
			//if (fileTabPage.FileDetails != null)
			//{
			//	if (options.OpenedFiles == fileTabPage.FileDetails.FileName)
			//	{
			//		options.OpenedFiles = String.Empty;
			//	}
			//	else
			//	{
			//		options.OpenedFiles = options.OpenedFiles.EndsWith($";{fileTabPage.FileDetails.FileName}")
			//			? options.OpenedFiles.Replace($";{fileTabPage.FileDetails.FileName}", String.Empty)
			//			: options.OpenedFiles.Replace($"{fileTabPage.FileDetails.FileName};", String.Empty);
			//	}
			//}
		}

		private void WrapLongLinesMenuItem_Click(object sender, EventArgs e)
		{
			foreach (FileTabPage tabPage in tabControl.TabPages)
			{
				tabPage.RefreshScrollBars(wrapLongLinesMenuItem.Checked);
			}
		}

		private void OpenMenuItem_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OpenFile(openFileDialog.FileName);
				//options.AppendToOpenedFiles(openFileDialog.FileName);
			}
		}

		private void OpenFile(string fileName)
		{
			var fileContent = fileReader.GetFileContent(fileName);
			var fileDetails = new FileDetails(fileName);
			OpenNewTab(fileDetails);
			var activeTab = tabControl.SelectedTab as FileTabPage;
			activeTab.TextBox.Text = fileContent;
		}

		public new void ShowDialog()
		{
			throw new NotSupportedException("This method is not supported, use 'Show' instead of this function.");
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
