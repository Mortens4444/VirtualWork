namespace VirtualWork.Interfaces.EmailService
{
	public class SmtpServerOptions : ISmtpServerOptions
	{
		public string SmtpServer { get; set; }

		public int SmtpServerPort { get; set; }

		public bool SmtpServerUseSSl { get; set; }

		public string SmtpServerUser { get; set; }

		public string SmtpServerPassword { get; set; }

		public int SmtpAuthentication { get; set; } = -1;
	}
}
