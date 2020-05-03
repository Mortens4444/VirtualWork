using VirtualWork.Interfaces.EmailService;

namespace VirtualWork.Service.EmailService
{
	class EmailSenderOptions : IEmailSenderOptions
	{
		public string SmtpServer => "mail.digikabel.hu";

		public int SmtpServerPort => 25;

		public bool SmtpServerUseSSl => false;

		public string SmtpServerUser => "user@digikabel.hu";

		public string SmtpServerPassword => "pass";

		public string SenderEmailAddress => "virtualwork@noreply.com";
	}
}
