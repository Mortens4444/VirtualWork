namespace VirtualWork.Interfaces.EmailService
{
	public interface ISmtpConfigurationProvider
	{
		ISmtpServerOptions Get(string smtpServer);
	}
}
