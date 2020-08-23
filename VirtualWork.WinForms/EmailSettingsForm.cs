using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class EmailSettingsForm : Form
	{
		private readonly ISmtpServerOptions smtpServerOptions;
		private readonly ISmtpConfigurationProvider smtpConfigurationProvider;
		private readonly SystemSettingsRepository systemSettingsRepository;

		public EmailSettingsForm(ISmtpServerOptions smtpServerOptions,
			ISmtpConfigurationProvider smtpConfigurationProvider,			
			SystemSettingsRepository systemSettingsRepository)
		{
			this.smtpServerOptions = smtpServerOptions;
			this.smtpConfigurationProvider = smtpConfigurationProvider;
			this.systemSettingsRepository = systemSettingsRepository;

			InitializeComponent();
			Translator.Translate(this);
		}

		private void CbConfigurationSchema_SelectedIndexChanged(object sender, EventArgs e)
		{
			var smtpSettings = smtpConfigurationProvider.Get(cbConfigurationSchema.Text);
			if (smtpSettings != null)
			{
				SetControlsEnabled(false);

				tbSmtpServer.Text = smtpSettings.SmtpServer;
				nudPort.Value = smtpSettings.SmtpServerPort;
				chkSslEncryption.Checked = smtpSettings.SmtpServerUseSSl;
				cbSmtpAuthentication.SelectedIndex = 0;
			}
			else
			{
				SetControlsEnabled(true);
			}
		}

		private void SetControlsEnabled(bool enabled)
		{
			tbSmtpServer.Enabled = enabled;
			nudPort.Enabled = enabled;
			chkSslEncryption.Enabled = enabled;
			cbSmtpAuthentication.Enabled = enabled;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			smtpServerOptions.SmtpServer = tbSmtpServer.Text;
			smtpServerOptions.SmtpServerPort = (int)nudPort.Value;
			smtpServerOptions.SmtpServerUseSSl = chkSslEncryption.Checked;
			smtpServerOptions.SmtpAuthentication = cbSmtpAuthentication.SelectedIndex - 1;
			smtpServerOptions.SmtpServerUser = tbUsername.Text;
			smtpServerOptions.SmtpServerPassword = tbPassword.Text;

			systemSettingsRepository.Update(smtpServerOptions);
		}

		private void EmailSettingsForm_Shown(object sender, EventArgs e)
		{
			var smtpServerOptions = systemSettingsRepository.GetSmtpServerOptions();

			tbSmtpServer.Text = smtpServerOptions.SmtpServer;
			nudPort.Value = smtpServerOptions.SmtpServerPort;
			chkSslEncryption.Checked = smtpServerOptions.SmtpServerUseSSl;
			cbSmtpAuthentication.SelectedIndex = smtpServerOptions.SmtpAuthentication;
			tbUsername.Text = smtpServerOptions.SmtpServerUser;
			tbPassword.Text = smtpServerOptions.SmtpServerPassword;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
