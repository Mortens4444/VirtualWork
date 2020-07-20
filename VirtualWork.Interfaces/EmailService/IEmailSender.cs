using System.Collections.Generic;
using VirtualWork.Interfaces.Actors;
using VirtualWork.Interfaces.Contacts;

namespace VirtualWork.Interfaces.EmailService
{
	public interface IEmailSender
	{
		void SetOptions(IEmailSenderOptions emailSenderOptions);

		void Send(INotifiable sender, HashSet<INotifiable> recipents, string title, string message);

		void Send(string sender, HashSet<IEmailAddress> recipents, string title, string message);

		void Send(string sender, string to, string cc, string bcc, string title, string message);
	}
}
