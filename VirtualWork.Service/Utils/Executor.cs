using EmailService;
using LanguageService;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Service.EmailService;
using VirtualWork.Service.Process;

namespace VirtualWork.Service.Utils
{
	public class Executor
	{
		private readonly ErrorBoxHelper errorBoxHelper;
		private readonly ProcessUtils processUtils;
		private readonly IEmailSender emailSender;
		private readonly Speech speech;

		private const string MessageBoxSender = "MessageBoxSender";
		private const string AutomaticMessage = "Automatic message";
		private const string NoMessageIsProvided = "No message is provided.";

		public Executor(ErrorBoxHelper errorBoxHelper,
			ProcessUtils processUtils,
			IEmailSender emailSender,
			Speech speech)
		{
			this.errorBoxHelper = errorBoxHelper;
			this.processUtils = processUtils;
			this.emailSender = emailSender;
			this.speech = speech;
		}

		public void Execute(string process, string arguments = null)
		{
			process = process.ToLower();

			switch (process)
			{
				//case "sendmail":
					// Send mail to groups or users?
					//emailSender.Send(EmailSender.DefaultSenderEmailAddress, null, null, null, Lng.Elem(AutomaticMessage), arguments);
					//break;
				case "infobox":
					processUtils.Start(MessageBoxSender, $"-info {GetBaseMessage(arguments)}");
					break;
				case "errorbox":
					processUtils.Start(MessageBoxSender, $"-error {GetBaseMessage(arguments)}");
					break;
				case "confirmbox":
					processUtils.Start(MessageBoxSender, $"-question {GetBaseMessage(arguments)}");
					break;
				case "speech":
					speech.Say(arguments ?? NoMessageIsProvided);
					break;
				default:
					processUtils.Start(process, arguments);
					break;
			}
		}

		private string GetBaseMessage(string message)
		{
			return $"-message {message ?? Lng.Elem(NoMessageIsProvided)} -title {Lng.Elem(AutomaticMessage)}";
		}
	}
}
