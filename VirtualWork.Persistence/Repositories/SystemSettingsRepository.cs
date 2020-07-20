using System;
using System.Linq.Expressions;
using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using SystemSettingDto = VirtualWork.Core.Settings.SystemSetting;

namespace VirtualWork.Persistence.Repositories
{
    public class SystemSettingsRepository : RepositoryBase<SystemSettingDto, SystemSetting>
    {
        public SystemSettingsRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			SystemSettingConverter systemSettingConverter)
            : base(mtfDatabase, systemSettingConverter, mtfDatabase.SystemSettings)
        {
        }

		protected override Expression<Func<SystemSetting, bool>> EntitySearchPredicate(object value)
		{
			return dbEntity => dbEntity.Name == (string)value;
		}
	}
}
