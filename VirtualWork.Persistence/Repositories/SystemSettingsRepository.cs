using System;
using System.Linq.Expressions;
using VirtualWork.Core.Cryptography.Ciphers.Production;
using VirtualWork.Interfaces.EmailService;
using VirtualWork.Persistence.Entities;
using SystemSettingConverter = VirtualWork.Persistence.Converters.ConverterBase<VirtualWork.Core.Settings.SystemSetting, VirtualWork.Persistence.Entities.SystemSetting>;
using SystemSettingDto = VirtualWork.Core.Settings.SystemSetting;

namespace VirtualWork.Persistence.Repositories
{
	public class SystemSettingsRepository : RepositoryBase<SystemSettingDto, SystemSetting>
    {
		private const string SmtpServer = "SmtpServer";
		private const string SmtpServerPort = "SmtpServerPort";
		private const string SmtpSslEncryption = "SmtpSslEncryption";
		private const string SmtpAuthentication = "SmtpAuthentication";
		private const string SmtpServerUsername = "SmtpServerUsername";
		private const string SmtpServerPassword = "SmtpServerPassword";

		private readonly ProductionCipher productionCipher;
		private readonly ProductionCipherKey encryptorKey;

		public SystemSettingsRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			SystemSettingConverter systemSettingConverter,
			PasswordHashRepository passwordHashRepository,
			ProductionCipher productionCipher)
            : base(mtfDatabase, systemSettingConverter, mtfDatabase.SystemSettings)
        {
			this.productionCipher = productionCipher;

			encryptorKey = passwordHashRepository.GetSystemEncryptionPassword("sd4lrR!FÉ.4SW3");
		}

		public ISmtpServerOptions GetSmtpServerOptions()
		{
			var result = new SmtpServerOptions();
			var smtpServer = Get(SmtpServer);
			if (smtpServer != null)
			{
				result.SmtpServer = (string)smtpServer;
				result.SmtpServerPort = Convert.ToInt32(Get(SmtpServerPort));
				result.SmtpServerUseSSl = Convert.ToBoolean(Get(SmtpSslEncryption));
				result.SmtpAuthentication = Convert.ToInt32(Get(SmtpAuthentication));
				result.SmtpServerUser = productionCipher.Decrypt((string)Get(SmtpServerUsername), encryptorKey);
				result.SmtpServerPassword = productionCipher.Decrypt((string)Get(SmtpServerPassword), encryptorKey);
			}
			return result;
		}

		protected override Expression<Func<SystemSetting, bool>> EntitySearchPredicate(SystemSettingDto dto)
		{
			return dbEntity => dbEntity.Name == dto.Name;
		}

		public object Get(string setting)
		{
			var result = Get(systemSetting => systemSetting.Name == setting);
			return result?.Value;
		}

		public void Update(ISmtpServerOptions smtpServerOptions)
		{
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpServer,
				Value = smtpServerOptions.SmtpServer
			});
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpServerPort,
				Value = smtpServerOptions.SmtpServerPort.ToString()
			});
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpSslEncryption,
				Value = smtpServerOptions.SmtpServerUseSSl.ToString()
			});
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpAuthentication,
				Value = smtpServerOptions.SmtpAuthentication.ToString()
			});
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpServerUsername,
				Value = productionCipher.Encrypt(smtpServerOptions.SmtpServerUser, encryptorKey)
			});
			AddOrUpdate(new SystemSettingDto
			{
				Name = SmtpServerPassword,
				Value = productionCipher.Encrypt(smtpServerOptions.SmtpServerPassword, encryptorKey)
			});
		}
	}
}
