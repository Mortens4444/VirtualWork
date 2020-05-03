using System;
using System.Collections.Generic;
using System.Linq;
using EmailService;
using EmailService.EventArgs;
using EmailService.Model;
using VirtualWork.Core.Contacts;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Interfaces.Log;

namespace VirtualWork.Service.EmailService
{
	public class EmailSender : IEmailSender
	{
		private readonly string senderEmailAddress;
		private readonly SmtpServer smtpServer;
		private readonly SendMail sendMail;
		private readonly ILogger logger;

		public EmailSender(IEmailSenderOptions emailSenderOptions, ILogger logger)
		{
			this.logger = logger;
			senderEmailAddress = emailSenderOptions.SenderEmailAddress;
			smtpServer = new SmtpServer(emailSenderOptions.SmtpServer, emailSenderOptions.SmtpServerPort, emailSenderOptions.SmtpServerUseSSl, emailSenderOptions.SmtpServerUser, emailSenderOptions.SmtpServerPassword, null, true);
			sendMail = new SendMail(smtpServer);
		}

		public void Send(HashSet<INotifiable> notifiables, string title, string message)
		{
			sendMail.SentChanged += SendMail_SentChanged;

			foreach (var notifiable in notifiables)
			{
				if (notifiable.Contacts.FirstOrDefault(contact => contact is Email) is Email email)
				{
					sendMail.Send(senderEmailAddress, email.Address, title, message);
				}
			}
		}

		private void SendMail_SentChanged(object sender, SentChangedEventArgs e)
		{
			var recipents = $"{e.To}, CC: {String.Join(", ", e.CC)}, BCC: {String.Join(", ", e.Bcc)}";
			if (e.Sent)
			{
				logger.Info($"E-mail message has been sent to {recipents} from {e.From}");
			}
			else
			{
				logger.Error($"E-mail message cannot be sent to {recipents} from {e.From}. Exception: {e.Exception}");
			}
		}
	}
}