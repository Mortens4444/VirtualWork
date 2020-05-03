using Ninject.Modules;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Interfaces.Log;
using VirtualWork.Service.EmailService;
using VirtualWork.Service.Log;

namespace VirtualWork.Service
{
	public class ServiceInjectionModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ILogger>().To<FileLogger>();
			Bind<IEmailSender>().To<EmailSender>();
			Bind<IEmailSenderOptions>().To<EmailSenderOptions>();
		}
	}
}
