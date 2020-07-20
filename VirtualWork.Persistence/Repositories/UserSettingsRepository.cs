using VirtualWork.Persistence.Converters;
using VirtualWork.Persistence.Entities;
using OptionDto = VirtualWork.Core.Settings.UserSetting;

namespace VirtualWork.Persistence.Repositories
{
    public class UserSettingsRepository : RepositoryBase<OptionDto, UserSetting>
    {
        public UserSettingsRepository(
            VirtualWorkDatabaseContext mtfDatabase,
			UserSettingConverter userSettingConverter)
            : base(mtfDatabase, userSettingConverter, mtfDatabase.UserSettings)
        {
        }

        /*public void CreateOptionForUser(string optionName, string value, string name)
        {
            var user = usersRepository.Value.Get(name);
            CreateOptionForUser(optionName, value, user);
        }

        public void CreateOptionForUser(string optionName, string value, UserDto user)
        {
            CreateOption(new Option
            {
                Name = optionName,
                Value = value,
                User = UserConverter.ToEntity(user)
            });
        }

        public void CreateOption(Option option)
        {
            VirtualWorkDatabase.Options.Add(option);
            VirtualWorkDatabase.SaveChanges();
        }

        public void CreateDefaultOptionsForUser(UserDto user)
        {
            var defaultOptions = GetDefaultOptionValues();
            foreach ((string OptionName, string DefaultValue) in defaultOptions)
            {
                CreateOptionForUser(OptionName, DefaultValue, user);
            }
        }

        private static IList<(string OptionName, string DefaultValue)> GetDefaultOptionValues()
        {
            return new List<(string, string)>
            {
                ("Language", "0")
            };
        }*/
    }
}
