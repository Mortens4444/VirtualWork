using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VirtualWork.WinForms.Dto;

namespace VirtualWork.WinForms.Controls
{
	public class FileRichTextBox : RichTextBox
	{
		private static int newDocumentNumber = 1;
		public FileDetails FileDetails { get; set; }

		public int DocumentNumber { get; }

		public FileRichTextBox()
		{
			Dock = DockStyle.Fill;
			Location = new Point(3, 3);
			DocumentNumber = newDocumentNumber++;
			Name = $"fileContent{DocumentNumber}";
			Size = new Size(705, 369);
			TabIndex = 0;
			Text = String.Empty;
		}

		public void RefreshScrollBars(bool wrapLongLines)
		{
			ScrollBars = wrapLongLines ? RichTextBoxScrollBars.Vertical : RichTextBoxScrollBars.Both;
			WordWrap = wrapLongLines;
		}

		protected override void OnLinkClicked(LinkClickedEventArgs e)
		{
			base.OnLinkClicked(e);
			Process.Start(e.LinkText);
		}

		protected override void OnTextChanged(EventArgs e)
		{
			if (FileDetails != null)
			{
				FileDetails.Changed = true;
			}
			base.OnTextChanged(e);
		}
	}
}
