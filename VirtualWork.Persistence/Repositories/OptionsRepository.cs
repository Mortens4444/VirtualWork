using System;
using System.Collections.Generic;
using VirtualWork.Persistence.Entities;

namespace VirtualWork.Persistence.Repositories
{
    public class OptionsRepository : RepositoryBase
    {
        private Lazy<UsersRepository> usersRepository;

        public OptionsRepository(
            Lazy<UsersRepository> usersRepository,
            Database mtfDatabase)
            : base(mtfDatabase)
        {
            this.usersRepository = usersRepository;
        }

        public void CreateOptionForUser(string optionName, string value, string name)
        {
            var user = usersRepository.Value.Get(name);
            CreateOptionForUser(optionName, value, user);
        }

        public void CreateOptionForUser(string optionName, string value, User user)
        {
            CreateOption(new Option
            {
                Name = optionName,
                Value = value,
                User = user
            });
        }

        public void CreateOption(Option option)
        {
            VirtualWorkDatabase.Options.Add(option);
            VirtualWorkDatabase.SaveChanges();
        }

        public void CreateDefaultOptionsForUser(User user)
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
        }
    }
}
