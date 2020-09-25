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

		public FileTabPage Create(FileDetails fileDetails, IContainer components, ContextMenuStrip contextMenuStrip)
		{
			var result = new FileTabPage(fileWriter);
			result.Initialize(fileDetails);
			result.TextBox.ContextMenuStrip = contextMenuStrip;
			return result;
		}
	}
}
