using System;
using System.Windows.Forms;
using LanguageService;
using LanguageService.Windows.Forms;
using MessageBoxes;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Service.EmailService;

namespace VirtualWork.WinForms
{
	public partial class SendMailForm : Form
	{
		private readonly IEmailSender emailSender;
		private readonly UserProfileForm userProfileForm;

		public SendMailForm(IEmailSender emailSender,
			UserProfileForm userProfileForm)
		{
			InitializeComponent();

			this.emailSender = emailSender;
			this.userProfileForm = userProfileForm;

			Translator.Translate(this);
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			emailSender.SetOptions(new EmailSenderOptions { ShowErrorMessages = true });
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
	}
}
