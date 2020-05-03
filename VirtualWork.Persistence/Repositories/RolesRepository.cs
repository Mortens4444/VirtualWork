using System;
using System.Linq;
using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.RoleHelp;

namespace VirtualWork.Persistence.Repositories
{
    public class RolesRepository : RepositoryBase
    {
        private readonly Lazy<UsersRepository> usersRepository;

        public RolesRepository(
            Lazy<UsersRepository> usersRepository,
            Database mtfDatabase)
            : base(mtfDatabase)
        {
            this.usersRepository = usersRepository;
        }

        public Role Get(string name)
        {
            if (!VirtualWorkDatabase.Roles.Any())
            {
                CreateRoles();
            }

            return VirtualWorkDatabase.Roles.SingleOrDefault(user => user.Name == name);
        }

        public void CreateRoles()
        {
            var roleNames = Enum.GetNames(typeof(RoleName));
            foreach (var roleName in roleNames)
            {
                CreateRole(roleName);
            }
            VirtualWorkDatabase.SaveChanges();
        }

        private Role CreateRole(string name)
        {
            var result = new Role { Name = name };
            VirtualWorkDatabase.Roles.Add(result);
            return result;
        }
    }
}
