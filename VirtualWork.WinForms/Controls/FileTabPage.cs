using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LanguageService;
using VirtualWork.Interfaces.Enums;
using VirtualWork.Service.FileHandling;
using VirtualWork.WinForms.Dto;

namespace VirtualWork.WinForms.Controls
{
	public class FileTabPage : TabPage
	{
		private readonly FileWriter fileWriter;
		private readonly Dictionary<string, ColoringMode> knownExtensions = new Dictionary<string, ColoringMode>
		{
			{ ".cpp", ColoringMode.CppCli },
			{ ".cs", ColoringMode.CSharp },
			{ ".java", ColoringMode.Java },
			{ ".pde", ColoringMode.Java },
			{ ".pas", ColoringMode.ObjectPascal },
			{ ".vb", ColoringMode.VisualBasic },
		};

		public FileTabPage(FileWriter fileWriter)
		{
			this.fileWriter = fileWriter;
		}

		public FileRichTextBox TextBox { get; private set; }

		public FileDetails FileDetails
		{
			get => TextBox.FileDetails;
			set => TextBox.FileDetails = value;
		}

		public void Initialize(FileDetails fileDetails)
		{
			TextBox = new FileRichTextBox();
			TextBox.Name = $"TextBox{TextBox.DocumentNumber}";
			Location = new Point(4, 22);
			Name = $"Tab{TextBox.DocumentNumber}";
			Padding = new Padding(3);
			Size = new Size(711, 375);
			TabIndex = 0;
			Text = fileDetails?.ShowFileName ?? $"{Lng.Elem("New document")} {TextBox.DocumentNumber}";
			if (fileDetails != null)
			{
				var extension = Path.GetExtension(fileDetails.FileName).ToLower();
				if (knownExtensions.ContainsKey(extension))
				{
					TextBox.ColoringMode = knownExtensions[extension];
				}
			}
			UseVisualStyleBackColor = true;
			Visible = false;

			Controls.Add(TextBox);
			TextBox.FileDetails = fileDetails;
		}

		public void SaveFile(/*OptionsDto options*/)
		{
			if (FileDetails != null)
			{
				fileWriter.CreateOrOverwriteFile(FileDetails.FileName, TextBox.Text);
			}
			else
			{
				var saveFileDialog = new SaveFileDialog();
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					fileWriter.CreateOrOverwriteFile(saveFileDialog.FileName, TextBox.Text);
					// TODO: Add in correct position, not to the end
					//options.AppendToOpenedFiles(saveFileDialog.FileName);
					FileDetails = new FileDetails(saveFileDialog.FileName);
					Text = FileDetails.ShowFileName;
				}
			}
		}

		public void RefreshScrollBars(bool wrapLongLines)
		{
			TextBox.RefreshScrollBars(wrapLongLines);
		}
	}

}
