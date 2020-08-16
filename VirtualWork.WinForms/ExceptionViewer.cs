using System;
using System.Drawing;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Service.Utils;

namespace VirtualWork.WinForms
{
	public partial class ExceptionViewer : Form
	{
		public ExceptionViewer(string exception)
		{
			InitializeComponent();
			Translator.Translate(this);

			rtb_ExceptionText.Text = exception;
		}

		private void ExceptionViewer_Shown(object sender, EventArgs e)
		{
			ClearInfo();

			try
			{
				rtb_ExceptionText.Text = rtb_ExceptionText.Text.Replace("\\r", "\r").Replace("\\n", "\n");
				if (String.IsNullOrWhiteSpace(rtb_ExceptionText.Text))
				{
					return;
				}

				byte add;
				var index = rtb_ExceptionText.Text.IndexOf("Type\":\"");
				if (index == -1)
				{
					index = rtb_ExceptionText.Text.IndexOf("ClassName\":\"");
					add = 12;
				}
				else
				{
					add = 7;
				}
				var startIndex = index + add;
				if (rtb_ExceptionText.Text.Length < startIndex)
				{
					return;
				}
				var endIndex = rtb_ExceptionText.Text.IndexOf("\",", startIndex);
				if (SetTextBoxText(tb_ExceptionType, startIndex, endIndex))
				{
					index = rtb_ExceptionText.Text.IndexOf("StringValue\":\"");
					if (index == -1)
					{
						index = rtb_ExceptionText.Text.IndexOf("Message\":\"");
						add = 10;
					}
					else
					{
						add = 14;
					}
					startIndex = index + add;
					endIndex = rtb_ExceptionText.Text.IndexOf("\n", startIndex) + 1;
					if (SetTextBoxText(tb_ExceptionMessage, startIndex, endIndex))
					{
						startIndex = rtb_ExceptionText.Text.IndexOf(" at ", endIndex) + 4;
						//startIndex = endIndex + 3;
						endIndex = rtb_ExceptionText.Text.IndexOf("\n", startIndex);
						SetTextBoxText(tb_LastStackElement, startIndex, endIndex);

						var parts = tb_LastStackElement.Text.Split(new[] { '.', '(' });
						if (parts.Length > 3)
						{
							tb_FunctionName.Text = parts[parts.Length - 2];
							var substract = tb_FunctionName.Text == "ctor" ? 4 : 3;
							tb_Filename.Text = parts[parts.Length - substract];
							if (tb_Filename.Text == "<>c")
							{
								tb_Filename.Text = parts[parts.Length - 4];
							}
							if (!String.IsNullOrWhiteSpace(tb_Filename.Text))
							{
								ClipboardHelper.SetText(tb_Filename.Text);
							}
						}
					}
				}
				else
				{
					SetTextBoxText(tb_FunctionName, 0, rtb_ExceptionText.Text.IndexOf('('));
					var classEndIndex = rtb_ExceptionText.Text.IndexOf('>');
					if (classEndIndex != -1)
					{
						SetTextBoxText(tb_Filename, rtb_ExceptionText.Text.IndexOf('<'), classEndIndex);
						SetTextBoxText(tb_LastStackElement, classEndIndex + 2, rtb_ExceptionText.Text.IndexOf('\n', classEndIndex + 2));
					}
					else
					{
						var start = rtb_ExceptionText.Text.IndexOf('\n') + 1;
						SetTextBoxText(tb_LastStackElement, start, rtb_ExceptionText.Text.IndexOf('\n', start + 1));
					}

					var messageStart = rtb_ExceptionText.Text.IndexOf("\n\n");
					SetTextBoxText(tb_ExceptionMessage, messageStart + 2, rtb_ExceptionText.Text.IndexOf('\n', messageStart + 2));

					var hynphen = tb_ExceptionMessage.Text.IndexOf(" - ");
					tb_ExceptionType.Text = tb_ExceptionMessage.Text.Substring(0, hynphen);
					tb_ExceptionMessage.Text = tb_ExceptionMessage.Text.Substring(hynphen + 3);

				}
				rtb_ExceptionText.Select(0, 0);
			}
			catch (Exception ex)
			{
				ErrorBoxHelper.Show(ex);
			}
		}

		private bool SetTextBoxText(TextBox textBox, int startIndex, int endIndex)
		{
			if (startIndex > -1 && endIndex > -1)
			{
				var length = endIndex - startIndex;
				textBox.Text = rtb_ExceptionText.Text.Substring(startIndex, length);
				rtb_ExceptionText.Select(startIndex, length);
				rtb_ExceptionText.SelectionFont = new Font(rtb_ExceptionText.Font, FontStyle.Bold);
				return true;
			}
			return false;
		}

		private void ClearInfo()
		{
			tb_ExceptionType.Text = String.Empty;
			tb_ExceptionMessage.Text = String.Empty;
			tb_LastStackElement.Text = String.Empty;
			tb_Filename.Text = String.Empty;
			tb_FunctionName.Text = String.Empty;
		}
	}
}
