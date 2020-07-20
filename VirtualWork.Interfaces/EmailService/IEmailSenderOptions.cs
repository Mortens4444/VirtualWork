namespace VirtualWork.Interfaces.EmailService
{
	public interface IEmailSenderOptions
	{
		string SenderEmailAddress { get; set; }

		bool ShowErrorMessages { get; set; }
	}
}
