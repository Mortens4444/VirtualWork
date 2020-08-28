using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using MessageBoxes;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Persistence.Repositories;
using VirtualWork.Service.EmailService;

namespace VirtualWork.WinForms
{
	public partial class SendMailForm : Form
	{
		private readonly IEmailSender emailSender;
		private readonly ISmtpServerOptions smtpServerOptions;
		private readonly UserProfileForm userProfileForm;
		private readonly EmailSettingsForm emailSettingsForm;

		public SendMailForm(IEmailSender emailSender,
			SystemSettingsRepository systemSettingsRepository,
			UserProfileForm userProfileForm,
			EmailSettingsForm emailSettingsForm)
		{
			this.emailSender = emailSender;
			this.userProfileForm = userProfileForm;
			this.emailSettingsForm = emailSettingsForm;
			smtpServerOptions = systemSettingsRepository.GetSmtpServerOptions();

			InitializeComponent();
			Translator.Translate(this);
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			emailSender.SetOptions(
				new EmailSenderOptions
				{
					SenderEmailAddress = Initializer.LoggedInUser.GetFirstEmailAddress()?.Address,
					ShowErrorMessages = true
				});
			try
			{
				emailSender.Send(Initializer.LoggedInUser.GetFirstEmailAddress()?.Address, tbTo.Text, tbCarbonCopy.Text, tbBlindCarbonCopy.Text, tbSubject.Text, rtbBody.Text);
			}
			catch (InvalidOperationException ex)
			{
				InfoBox.Show(Lng.Elem("Missing e-mail address"), Lng.Elem(ex.Message));
				userProfileForm.ShowDialog();
			}
		}

		private void SendMailForm_Shown(object sender, EventArgs e)
		{
			var smtpServer = smtpServerOptions.SmtpServer;
			if (smtpServer == null)
			{
				if (emailSettingsForm.ShowDialog() != DialogResult.OK)
				{
					btnSend.Enabled = false;
				}
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
