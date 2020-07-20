namespace VirtualWork.Interfaces.EmailService
{
	public interface ISmtpServerOptions
	{
		string SmtpServer { get; set; }

		int SmtpServerPort { get; set; }

		bool SmtpServerUseSSl { get; set; }

		string SmtpServerUser { get; set; }

		string SmtpServerPassword { get; set; }

		int SmtpAuthentication { get; }
	}
}
