using System.Linq;
using System.Security.Principal;
using System.Threading;
using VirtualWork.Persistence.Entities;

namespace VirtualWork.Persistence
{
	public static class PermissionHandler
    {
        public static void SetPrincipals(User user)
        {
            var principals = user.Roles.Select(userRole => userRole.Role.Name).ToArray();
            var genericIdentity = new GenericIdentity(user.Name);
            Thread.CurrentPrincipal = new GenericPrincipal(genericIdentity, principals);
        }
    }
}
