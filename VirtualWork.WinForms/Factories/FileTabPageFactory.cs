using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VirtualWork.Service.FileHandling;
using VirtualWork.WinForms.Controls;
using VirtualWork.WinForms.Dto;

namespace VirtualWork.WinForms.Factories
{
	public class FileTabPageFactory
	{
		private readonly FileWriter fileWriter;

		public FileTabPageFactory(FileWriter fileWriter)
		{
			this.fileWriter = fileWriter;
		}

		public FileTabPage Create(FileDetails fileDetails, IContainer components, ToolStripItem[] menuItems)
		{
			var result = new FileTabPage(fileWriter);
			result.Initialize(fileDetails);
			var contextMenuStrip = new ContextMenuStrip(components);
			contextMenuStrip.Items.AddRange(menuItems);
			contextMenuStrip.Name = $"contextMenuStrip";
			contextMenuStrip.Size = new Size(197, 98);
			contextMenuStrip.Opening += (object sender, CancelEventArgs e) =>
			{
				menuItems[0].Enabled = result.FileDetails != null;
			};
			result.ContextMenuStrip = contextMenuStrip;
			result.TextBox.ContextMenuStrip = contextMenuStrip;
			return result;
		}
	}
}
