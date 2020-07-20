using VirtualWork.Interfaces.EmailService;

namespace VirtualWork.Service.EmailService
{
	public class EmailSenderOptions : IEmailSenderOptions
	{
		public string SenderEmailAddress { get; set; }

		public bool ShowErrorMessages { get; set; }
	}
}
