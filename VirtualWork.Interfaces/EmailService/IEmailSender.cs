using System.Collections.Generic;
using VirtualWork.Interfaces.Actors;

namespace VirtualWork.Interfaces.EmailService
{
	public interface IEmailSender
	{
		void Send(HashSet<INotifiable> notifiables, string title, string message);
	}
}
