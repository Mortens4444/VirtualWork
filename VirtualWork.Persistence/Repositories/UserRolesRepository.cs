using VirtualWork.Persistence.Entities;
using VirtualWork.Persistence.RoleHelp;
using System;
using System.Linq;

namespace VirtualWork.Persistence.Repositories
{
    public class UserRolesRepository : RepositoryBase
    {
        private readonly Lazy<UsersRepository> usersRepository;

        private Lazy<RolesRepository> rolesRepository;

        public UserRolesRepository(
            Lazy<UsersRepository> usersRepository,
            Lazy<RolesRepository> rolesRepository,
            Database mtfDatabase)
            : base(mtfDatabase)
        {
            this.usersRepository = usersRepository;
            this.rolesRepository = rolesRepository;
        }

        public Role Get(string name)
        {
            return VirtualWorkDatabase.Roles.SingleOrDefault(user => user.Name == name);
        }

        public void AddUserToRole(User user, Role role)
        {
            var userRole = VirtualWorkDatabase.UserRoles.Find(user.Id, role.Id);
            if (userRole == null)
            {
                VirtualWorkDatabase.UserRoles.Add(new UserRole
                {
                    User = user,
                    Role = role
                });

                VirtualWorkDatabase.SaveChanges();
                PermissionHandler.SetPrincipals(user);
            }
        }

        public void RemoveUserFromRole(User user, Role role)
        {
            var userRole = VirtualWorkDatabase.UserRoles.Find(user.Id, role.Id);
            if (userRole != null)
            {
                VirtualWorkDatabase.UserRoles.Remove(userRole);
                VirtualWorkDatabase.SaveChanges();
                PermissionHandler.SetPrincipals(user);
            }
        }

        public void CreateDefaultRolesForUser(User user)
        {
            var defaultRoleNames = VirtualWorkDatabase.Users.Any() ? RoleDistributor.GetAdvancedRoles() : RoleDistributor.GetBasicRoles();
            foreach (var roleName in defaultRoleNames)
            {
                var role = rolesRepository.Value.Get(roleName.ToString());
                AddUserToRole(user, role);
            }
        }
    }
}
