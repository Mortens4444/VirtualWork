using System;
using System.Windows.Forms;
using LanguageService.Windows.Forms;
using VirtualWork.Core.Settings;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms
{
	public partial class EmailSettingsForm : Form
	{
		private readonly ISmtpConfigurationProvider smtpConfigurationProvider;
		private readonly SystemSettingsRepository systemSettingsRepository;

		public EmailSettingsForm(ISmtpConfigurationProvider smtpConfigurationProvider,
			SystemSettingsRepository systemSettingsRepository)
		{
			InitializeComponent();
			Translator.Translate(this);

			this.smtpConfigurationProvider = smtpConfigurationProvider;
			this.systemSettingsRepository = systemSettingsRepository;
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
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpServer",
				Value = tbSmtpServer.Text
			});
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpServerPort",
				Value = nudPort.Value.ToString()
			});
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpSslEncryption",
				Value = chkSslEncryption.Checked.ToString()
			});
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpAuthentication",
				Value = (cbSmtpAuthentication.SelectedIndex - 1).ToString()
			});
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpServerUsername",
				Value = tbUsername.Text
			});
			systemSettingsRepository.AddOrUpdate(new SystemSetting
			{
				Name = "SmtpServerPassword",
				Value = tbPassword.Text
			});
		}
	}
}
