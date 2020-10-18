using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Service.Process;

namespace VirtualWork.WinForms
{
	public partial class CalculatorForm : Form
	{
		private const string SyntaxError = "Syntax error";

		private readonly ProcessUtils processUtils;
		private readonly Regex regex = new Regex(@"^[\d+\-*\/\.%]+$", RegexOptions.Compiled);

		public CalculatorForm(ProcessUtils processUtils)
		{
			this.processUtils = processUtils;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void BtnEqual_Click(object sender, EventArgs e)
		{
			tbResult.Text = Calculate(tbResult.Text);
		}

		private string Calculate(string expression)
		{
			if (regex.IsMatch(expression))
			{
				var process = processUtils.StartWithRedirect("PowerShell", expression);
				process.WaitForExit();
				return process.StandardOutput.ReadToEnd().Trim().Replace(",", ".");
			}
			else
			{
				return SyntaxError;
			}
		}

		private void BtnAppend_Click(object sender, EventArgs e)
		{
			var buttonText = ((Button)sender).Text;
			if (tbResult.Text == "0" || tbResult.Text == SyntaxError)
			{
				tbResult.Text = buttonText;
			}
			else
			{
				tbResult.Text += buttonText;
			}
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
