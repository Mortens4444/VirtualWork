using System;
using System.Collections.Generic;
using System.Linq;
using EmailService;
using EmailService.Enum;
using EmailService.EventArgs;
using EmailService.Model;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Contacts;
using VirtualWork.Interfaces.EmailService;

namespace VirtualWork.Service.EmailService
{
	public class EmailSender : IEmailSender
	{
		private readonly SmtpServer smtpServer;
		private readonly SendMail sendMail;
		private string systemSenderEmailAddress = "virtualwork@noreply.com";
		private bool showMessages;

		public EmailSender(ISmtpServerOptions smtpServerOptions)
		{
			var smtpAuthentication = smtpServerOptions.SmtpAuthentication == -1 ? (SmtpAuthentication?)null : (SmtpAuthentication)smtpServerOptions.SmtpAuthentication;
			smtpServer = new SmtpServer(smtpServerOptions.SmtpServer, smtpServerOptions.SmtpServerPort, smtpServerOptions.SmtpServerUseSSl, smtpServerOptions.SmtpServerUser, smtpServerOptions.SmtpServerPassword, smtpAuthentication, true);
			sendMail = new SendMail(smtpServer);
		}

		public void Send(INotifiable sender, HashSet<INotifiable> recipents, string title, string message)
		{
			string senderEmailAddress;
			if (systemSenderEmailAddress != null && sender != null)
			{
				CheckSenderEmailExistence(sender);
				senderEmailAddress = sender.GetFirstEmailAddress()?.Address;
			}
			else
			{
				senderEmailAddress = systemSenderEmailAddress;
			}

			var recipentsEmailAddresses = recipents
				.Select(notifiable => notifiable.GetFirstEmailAddress())
				.Where(emailAddress => emailAddress != null)
				.ToHashSet();
			Send(senderEmailAddress, recipentsEmailAddresses, title, message);
		}

		public void Send(string sender, HashSet<IEmailAddress> recipents, string title, string message)
		{
			CheckSenderEmailExistence(sender);
			sendMail.SentChanged += SendMail_SentChanged;
			foreach (var recipent in recipents)
			{
				sendMail.Send(sender, recipent.Address, title, message);
			}
		}

		public void Send(string sender, string to, string cc, string bcc, string title, string message)
		{
			CheckSenderEmailExistence(sender);
			sendMail.SentChanged += SendMail_SentChanged;
			sendMail.Send(sender, to, title, message, cc, bcc);
		}

		private static void CheckSenderEmailExistence(object sender)
		{
			if (sender == null)
			{
				throw new InvalidOperationException("You need to add an e-mail address to your profile.");
			}
		}

		private void SendMail_SentChanged(object sender, SentChangedEventArgs e)
		{
			if (showMessages)
			{

			}
		}

		public void SetOptions(IEmailSenderOptions emailSenderOptions)
		{
			showMessages = emailSenderOptions.ShowErrorMessages;
			systemSenderEmailAddress = emailSenderOptions.SenderEmailAddress;
		}
	}
}