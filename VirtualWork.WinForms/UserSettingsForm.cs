using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class UserSettingsForm : Form
	{
		private readonly UserSettingsRepository userSettingsRepository;

		public UserSettingsForm(UserSettingsRepository userSettingsRepository)
		{
			this.userSettingsRepository = userSettingsRepository;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{

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

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
