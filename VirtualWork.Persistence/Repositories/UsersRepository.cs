using VirtualWork.Persistence.Entities;
using System;
using System.Linq;

namespace VirtualWork.Persistence.Repositories
{
    public class UsersRepository : RepositoryBase
    {
        private Lazy<OptionsRepository> optionsRepository;

        private Lazy<UserRolesRepository> userRolesRepository;

        public UsersRepository(
            Lazy<OptionsRepository> optionsRepository,
            Lazy<UserRolesRepository> userRolesRepository,
            Database mtfDatabase)
            : base(mtfDatabase)
        {
            this.optionsRepository = optionsRepository;
            this.userRolesRepository = userRolesRepository;
        }

        public User Get(string name)
        {
            var result = VirtualWorkDatabase.Users.SingleOrDefault(user => user.Name == name);
            if (result != null)
            {
                PermissionHandler.SetPrincipals(result);
            }
            return result;
        }

        public User GetOrCreate(string name)
        {
            var result = Get(name);
            if (result != null)
            {
                return result;
            }
            result = new User { Name = name };
            VirtualWorkDatabase.Users.Add(result);
            optionsRepository.Value.CreateDefaultOptionsForUser(result);
            userRolesRepository.Value.CreateDefaultRolesForUser(result);
            PermissionHandler.SetPrincipals(result);

            VirtualWorkDatabase.SaveChanges();
            return result;
        }
    }
}
