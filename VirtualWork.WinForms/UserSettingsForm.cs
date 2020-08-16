using System;
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
	}
}
