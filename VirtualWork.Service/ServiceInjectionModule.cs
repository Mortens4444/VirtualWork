using Ninject.Modules;
using VirtualWork.Interfaces.Date;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Interfaces.Log;
using VirtualWork.Service.Date;
using VirtualWork.Service.EmailService;
using VirtualWork.Service.Log;

namespace VirtualWork.Service
{
	public class ServiceInjectionModule : NinjectModule
	{
		public override void Load()
		{
			//Bind<ILogger>().To<FileLogger>();
			Bind<ILogger>().To<DatabaseLogger>();
			Bind<ISmtpServerOptions>().To<SmtpServerOptions>().InSingletonScope();
			Bind<ISmtpConfigurationProvider>().To<SmtpConfigurationProvider>();
			Bind<IEmailSender>().To<EmailSender>();
			Bind<IDateTimeProvider>().To<DateTimeProvider>();
		}
	}
}
