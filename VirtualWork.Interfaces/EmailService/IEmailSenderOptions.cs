namespace VirtualWork.Interfaces.EmailService
{
	public interface IEmailSenderOptions
	{
		string SmtpServer { get; }

		int SmtpServerPort { get; }

		bool SmtpServerUseSSl { get; }

		string SmtpServerUser { get; }

		string SmtpServerPassword { get; }

		string SenderEmailAddress { get; }
	}
}
