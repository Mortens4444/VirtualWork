using System.Collections.Generic;
using VirtualWork.Interfaces.EmailService;

namespace VirtualWork.Service.EmailService
{
	class SmtpConfigurationProvider : ISmtpConfigurationProvider
	{
		private static readonly Dictionary<string, ISmtpServerOptions> KnownConfigurations = new Dictionary<string, ISmtpServerOptions>
		{
			{
				"smtp.gmail.com (TLS)",
				new SmtpServerOptions
				{
					SmtpServer = "smtp.gmail.com",
					SmtpServerPort = 587,
					SmtpServerUseSSl = true,
					SmtpAuthentication = -1
				}
			},
			{
				"smtp.gmail.com (SSL)",
				new SmtpServerOptions
				{
					SmtpServer = "smtp.gmail.com",
					SmtpServerPort = 465,
					SmtpServerUseSSl = true,
					SmtpAuthentication = -1
				}
			},
			{
				"mail.digikabel.hu",
				new SmtpServerOptions
				{
					SmtpServer = "mail.digikabel.hu",
					SmtpServerPort = 25,
					SmtpServerUseSSl = false,
					SmtpAuthentication = -1
				}
			}
		};

		public ISmtpServerOptions Get(string smtpServer)
		{
			if (!KnownConfigurations.ContainsKey(smtpServer))
			{
				return null;
			}

			return KnownConfigurations[smtpServer];
		}
	}
}
